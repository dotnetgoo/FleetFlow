using AutoMapper;
using FleetFlow.Domain.Enums;
using FleetFlow.Shared.Helpers;
using FleetFlow.Domain.Entities;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.DTOs.Orders;
using Microsoft.EntityFrameworkCore;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Bonuses;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Bonuses;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Service.Interfaces.Addresses;

namespace FleetFlow.Service.Services.Orders;

public class CheckoutService : ICheckoutService
{
    private readonly IMapper mapper;
    private readonly IOrderService orderService;
    private readonly IAddressService addressService;
    private readonly IPaymentService paymentService;
    private readonly IRepository<Order> orderRepository;
    private readonly IRepository<Bonus> bonusRepository;
    private readonly IRepository<Region> regionRepository;
    private readonly IRepository<Address> addressRepository;
    private readonly IRepository<District> districtRepository;
    private readonly IRepository<CartItem> cartItemRepository;
    private readonly IRepository<BonusSetting> bonusSettingRepository;
    public CheckoutService(
        IMapper mapper,
        IOrderService orderService,
        IAddressService addressService,
        IPaymentService paymentService,
        IRepository<Bonus> bonusRepository,
        IRepository<Order> orderRepository,
        IRepository<Region> regionRepository,
        IRepository<Address> addressRepository,
        IRepository<District> districtRepository,
        IRepository<CartItem> cartItemRepository,
        IRepository<BonusSetting> bonusSettingRepository)
    {
        this.mapper = mapper;
        this.orderService = orderService;
        this.addressService = addressService;
        this.paymentService = paymentService;
        this.orderRepository = orderRepository;
        this.bonusRepository = bonusRepository;
        this.regionRepository = regionRepository;
        this.addressRepository = addressRepository;
        this.districtRepository = districtRepository;
        this.cartItemRepository = cartItemRepository;
        this.bonusSettingRepository = bonusSettingRepository;
    }

    public async ValueTask<AddressForResultDto> AssignAddressAsync(AddressAddDto addressDto)
    {
        var order = await orderRepository.SelectAll(o => o.UserId == HttpContextHelper.UserId
            && o.Status == OrderStatus.Checkout)
            .OrderBy(o => o.Id)
            .LastOrDefaultAsync();
        if (order == null)
            throw new FleetFlowException(404, "Order not found in 'checkout' status");

        Region region = await regionRepository.SelectAsync(r => r.Id == addressDto.RegionId);
        Address address = await addressRepository.SelectAsync(a => a.Id == addressDto.AddressId);
        District district = await districtRepository.SelectAsync(d => d.Id == addressDto.DistrictId);

        order.Region = region;
        order.Address = address;
        order.District = district;
        order.RegionId = addressDto.RegionId;
        order.DistrictId = addressDto.DistrictId;

        orderRepository.Update(order);
        await orderRepository.SaveAsync();

        return mapper.Map<AddressForResultDto>(order.Address);
    }

    public async ValueTask<OrderResultDto> SaveOrderAsync(OrderForCreationDto orderDto, string promoCode = null)
    {
        var createdOrder = await this.orderService.AddAsync(orderDto);
        if (createdOrder.IsSaved)
            throw new FleetFlowException(400, "This order is already saved");

        await CheckBonusAsync(createdOrder, promoCode);
        createdOrder.IsSaved = true;
        await this.orderRepository.SaveAsync();
        return this.mapper.Map<OrderResultDto>(createdOrder);
    }

    private async Task<BonusResultDto> CheckBonusAsync(OrderResultDto createdOrder, string promoCode = null)
    {
        var order = await this.orderRepository.SelectAsync(o => o.Id == createdOrder.Id);

        decimal sumOfOrder = 0.0m;
        foreach (var item in createdOrder.OrderItems)
            sumOfOrder += item.AmountTotal;

        var oldBonus = await this.bonusRepository
            .SelectAll()
            .OrderBy(b => b.Id)
            .LastOrDefaultAsync(b => b.UserId == HttpContextHelper.UserId);

        var bonus = new Bonus();

        var bonusSettings = await this.bonusSettingRepository.SelectAll().ToListAsync();


        BonusSetting bonusSettingWithPromoCode = bonusSettings
            .FirstOrDefault(b => b.PromoCode.Equals(promoCode) &&
            b.StartTime <= DateTime.UtcNow && b.EndTime >= DateTime.UtcNow);

        if (!string.IsNullOrEmpty(promoCode) && bonusSettingWithPromoCode.IsPromoCodeUsed)
        {
            string validPromoCode = bonusSettingWithPromoCode.PromoCode;

            if (string.IsNullOrEmpty(validPromoCode))
                throw new FleetFlowException(400, "This promo code is expired or invalid");

            switch (bonusSettingWithPromoCode.Type)
            {
                case BonusType.Amount:
                    bonus.Amount = oldBonus.Amount + bonusSettingWithPromoCode.Amount;
                    bonus.OrderDate = order.CreatedAt;
                    bonus.OrderId = order.Id;
                    bonus.UserId = (long)HttpContextHelper.UserId;
                    bonus.Type = BonusType.Amount;
                    bonus.IsPromoCodeUsed = true;
                    bonus.UsedPromoCode = validPromoCode;
                    break;
                case BonusType.Percentage:
                    bonus.Amount = oldBonus.Amount + (bonusSettingWithPromoCode.Amount / 100) * sumOfOrder;
                    bonus.OrderDate = order.CreatedAt;
                    bonus.OrderId = order.Id;
                    bonus.UserId = (long)HttpContextHelper.UserId;
                    bonus.Type = BonusType.Amount;
                    bonus.IsPromoCodeUsed = true;
                    bonus.UsedPromoCode = validPromoCode;
                    break;
                case BonusType.Gift:
                    bonus.Amount = oldBonus.Amount;
                    bonus.ProductId = bonusSettingWithPromoCode.ProductId;
                    bonus.OrderDate = order.CreatedAt;
                    bonus.OrderId = order.Id;
                    bonus.UserId = (long)HttpContextHelper.UserId;
                    bonus.OrderCashBack = bonusSettingWithPromoCode.Amount;
                    bonus.Type = BonusType.Gift;
                    bonus.IsPromoCodeUsed = true;
                    bonus.UsedPromoCode = validPromoCode;
                    break;
            }
            bonus = await this.bonusRepository.InsertAsync(bonus);
            await this.bonusRepository.SaveAsync();
        }

        var bonusSetting = new BonusSetting();
        foreach (var item in bonusSettings)
        {
            if (item.AmountFrom <= sumOfOrder && item.AmountTo >= sumOfOrder)
                bonusSetting = item;
        }

        // for amount
        if (bonusSetting is not null)
        {
            if (bonusSetting.StartTime <= DateTime.UtcNow && bonusSetting.EndTime >= DateTime.UtcNow)
            {
                switch (bonusSetting.Type)
                {
                    case BonusType.Amount:
                        bonus.Amount = oldBonus?.Amount ?? 0.0m + bonusSetting.Amount;
                        bonus.OrderDate = order.CreatedAt;
                        bonus.OrderId = order.Id;
                        bonus.UserId = (long)HttpContextHelper.UserId;
                        bonus.OrderCashBack = bonusSetting.Amount;
                        bonus.Type = BonusType.Amount;
                        break;
                    case BonusType.Percentage:
                        bonus.Amount = oldBonus.Amount + (bonusSetting.Amount / 100) * sumOfOrder;
                        bonus.OrderDate = order.CreatedAt;
                        bonus.OrderId = order.Id;
                        bonus.UserId = (long)HttpContextHelper.UserId;
                        bonus.OrderCashBack = bonusSetting.Amount;
                        bonus.Type = BonusType.Percentage;
                        break;
                    case BonusType.Gift:
                        bonus.Amount = oldBonus.Amount;
                        bonus.ProductId = bonusSetting.ProductId;
                        bonus.OrderDate = order.CreatedAt;
                        bonus.OrderId = order.Id;
                        bonus.UserId = (long)HttpContextHelper.UserId;
                        bonus.OrderCashBack = bonusSetting.Amount;
                        bonus.Type = BonusType.Gift;
                        break;
                }
            }
            bonus = await this.bonusRepository.InsertAsync(bonus);
            await this.bonusRepository.SaveAsync();
        }

        return this.mapper.Map<BonusResultDto>(bonus);
    }


    public async ValueTask<PaymentResultDto> PayAsync(PaymentCreationDto dto, AttachmentCreationDto attachment)
    {
        return await this.paymentService.AddAsync(dto, attachment);
    }

    public async ValueTask<IEnumerable<CartItemResultDto>> GetAllCartItemsAsync()
    {
        var cartItems = await this.cartItemRepository
            .SelectAll(c => c.Cart.UserId == HttpContextHelper.UserId, includes: new string[] { "Product" })
            .ToListAsync();

        return this.mapper.Map<IEnumerable<CartItemResultDto>>(cartItems);
    }

    public async ValueTask<AddressForResultDto> RetrieveLastAddressAsync()
    {
        var order = await orderRepository.SelectAll(o => o.UserId == HttpContextHelper.UserId)
            .OrderBy(o => o.Id)
            .LastOrDefaultAsync();

        return await addressService.GetByIdAsync(order?.AddressId ?? 0);
    }
}
