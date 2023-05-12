using AutoMapper;
using FleetFlow.Domain.Entities;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.Services;

public class PaymentService : IPaymentService
{
    private readonly IMapper mapper;
    private readonly IUserService userService;
    private readonly IRepository<Order> orderRepository;
    private readonly IAttachmantService attachmantService;
    private readonly IRepository<Payment> paymentRepository;
    public PaymentService(
        IMapper mapper,
        IUserService userService,
        IRepository<Order> orderRepository,
        IAttachmantService attachmantService,
        IRepository<Payment> paymentRepositor)
    {
        this.mapper = mapper;
        this.userService = userService;
        this.orderRepository = orderRepository;
        this.paymentRepository = paymentRepository;
        this.attachmantService = attachmantService;
    }

    public async Task<PaymentResultDto> AddAsync(PaymentCreationDto dto)
    {
        UserForResultDto user = await this.userService.RetrieveByIdAsync(dto.UserId);
        Order order = await this.orderRepository.SelectAsync(t => t.Id == dto.OrderId);

        Attachment file = await this.attachmantService.UploadAsync(dto.File);

        PaymentResultDto result = new PaymentResultDto
        {
            Amount = dto.Amount,
            Description = dto.Description,
            FileName = file.FileName,
            FilePath = file.FilePath, 
            Order = this.mapper.Map<OrderResultDto>(order),
            User = user,
            Status = Domain.Enums.PaymentStatus.Pending
        };
    }

    public Task<PaymentResultDto> ChangeStatusAsync(long id, PaymentStatus status)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentResultDto> ModifyAsync(long id, PaymentCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PaymentResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
