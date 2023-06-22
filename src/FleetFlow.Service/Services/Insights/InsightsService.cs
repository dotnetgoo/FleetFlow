using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Comparers;
using FleetFlow.Service.Interfaces.Insights;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Service.Models.Insights;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Insights;

public class InsightsService : IInsightsService
{
    private IUserService userService;
    private IProductService productService;
    private IRepository<User> userRepository;
    private IRepository<Order> orderRepository;
    private IRepository<Payment> paymentRepository;
    private IRepository<Product> productRepository;
    private IRepository<OrderItem> orderItemRepository;

    public InsightsService(IRepository<Order> orderRepository,
        IRepository<OrderItem> orderItemRepository,
        IRepository<Payment> paymentRepository,
        IRepository<Product> productRepository,
        IProductService productService,
        IUserService userService,
        IRepository<User> userRepository)
    {
        this.userService = userService;
        this.productService = productService;
        this.userRepository = userRepository;
        this.orderRepository = orderRepository;
        this.paymentRepository = paymentRepository;
        this.productRepository = productRepository;
        this.orderItemRepository = orderItemRepository;
    }

    public async Task<SellsTableModel> GetSellsTableAsync(InsightsParams parameters)
    {
        var sellsTable = new SellsTableModel();

        sellsTable.SumOfSells = (decimal)await paymentRepository
            .SelectAll(p => !p.IsDeleted && p.CreatedAt <= parameters.To && p.CreatedAt >= parameters.From)
            .SumAsync(p => p.Amount);

        sellsTable.NumberOfOrders = await orderRepository
            .SelectAll(o => !o.IsDeleted && o.CreatedAt <= parameters.To && o.CreatedAt >= parameters.From && o.PaymentStatus == PaymentStatus.Paid)
            .Select(o => o.Id)
            .CountAsync();

        sellsTable.NumberOfOrderedUsers = await orderRepository
            .SelectAll(o => !o.IsDeleted && o.CreatedAt <= parameters.To && o.CreatedAt >= parameters.From && o.PaymentStatus == PaymentStatus.Paid)
            .Select(o => o.UserId)
            .Distinct<long>()
            .CountAsync();

        sellsTable.AvarageOrder = sellsTable.NumberOfOrders != 0
                                ? sellsTable.SumOfSells / sellsTable.NumberOfOrders
                                : 0;
        sellsTable.From = parameters.From;
        sellsTable.To = parameters.To;

        return sellsTable;
    }

    public async Task<IEnumerable<TopProductModel>> GetTopProductsAsync(InsightsParams parameters)
    {
        var allProductModels = new List<TopProductModel>();
        var allProductIdAndPrices = await productRepository
            .SelectAll(p => !p.IsDeleted)
            .Select(p => new { p.Id, p.Price })
            .ToArrayAsync();

        foreach (var product in allProductIdAndPrices)
        {
            var productModel = new TopProductModel() { ProductId = product.Id };

            productModel.SellsNumber = await orderItemRepository
                .SelectAll(o => o.ProductId == product.Id && !o.IsDeleted && o.CreatedAt <= parameters.To && o.CreatedAt >= parameters.From)
                .Select(o => o.Amount)
                .SumAsync();

            productModel.SumOfSells = productModel.SellsNumber * product.Price;

            allProductModels.Add(productModel);
        }

        allProductModels.Sort(new SumOfSellsComparer());
        allProductModels.Reverse();

        var topProductModels = allProductModels.Take(parameters.Top).ToList();

        int i = 0;
        foreach (var item in allProductModels)
        {
            item.Product = await productService.RetrieveByIdAsync(item.ProductId);
            item.From = parameters.From;
            item.To = parameters.To;
            item.Top = ++i;
        }

        return topProductModels;
    }

    public async Task<IEnumerable<TopUserModel>> GetTopUsersAsync(InsightsParams parameters)
    {
        var allUserModels = new List<TopUserModel>();
        var allUserIds = await userRepository
            .SelectAll(u => !u.IsDeleted)
            .Select(p => p.Id)
            .ToArrayAsync();

        foreach (var userId in allUserIds)
        {
            var userModel = new TopUserModel() { UserId = userId };

            userModel.SumOfAllOrders = (decimal)await paymentRepository
                .SelectAll(p => p.UserId == userId && !p.IsDeleted && p.CreatedAt <= parameters.To && p.CreatedAt >= parameters.From)
                .Select(p => p.Amount)
                .SumAsync();

            allUserModels.Add(userModel);
        }

        allUserModels.Sort(new SumOfOrdersComparer());
        allUserModels.Reverse();

        var topUserModels = allUserModels.Take(parameters.Top).ToList();

        int i = 0;
        foreach (var item in allUserModels)
        {
            item.User = await userService.RetrieveByIdAsync(item.UserId);
            item.From = parameters.From;
            item.To = parameters.To;
            item.Top = ++i;
            item.AllOrdersNumber = await orderRepository
                .SelectAll(o => o.UserId == item.UserId && !o.IsDeleted && o.PaymentStatus == PaymentStatus.Paid && o.CreatedAt <= parameters.To && o.CreatedAt >= parameters.From)
                .Select(o => o.Id)
                .CountAsync();
        }

        return topUserModels;
    }
}