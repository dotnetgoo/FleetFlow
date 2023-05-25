using FleetFlow.DAL.Repositories;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Interfaces.Insights;
using FleetFlow.Service.Models.Insights;
using FleetFlow.Service.Services.Products;
using FleetFlow.Service.Services.Users;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Xml.Schema;

namespace FleetFlow.Service.Services.Insights;

public class InsightsService : IInsightsService
{
    private UserService userService;
    private ProductService productService;
    private Repository<User> userRepository;
    private Repository<Order> orderRepository;
    private Repository<Payment> paymentRepository;
    private Repository<Product> productRepository;
    private Repository<OrderItem> orderItemRepository;

    public InsightsService(Repository<Order> orderRepository,
        Repository<OrderItem> orderItemRepository,
        Repository<Payment> paymentRepository,
        Repository<Product> productRepository,
        ProductService productService,
        UserService userService,
        Repository<User> userRepository = null)
    {
        this.userService = userService;
        this.productService = productService;
        this.userRepository = userRepository;
        this.orderRepository = orderRepository;
        this.paymentRepository = paymentRepository;
        this.productRepository = productRepository;
        this.orderItemRepository = orderItemRepository;
    }

    public async Task<SellsTableModel> GetSellsTableAsync(DateTime from, DateTime to)
    {
        var sellsTable = new SellsTableModel();

        sellsTable.SumOfSells = (decimal) await paymentRepository
            .SelectAll(p => !p.IsDeleted && p.CreatedAt <= to && p.CreatedAt >= from)
            .SumAsync(p => p.Amount);

        sellsTable.NumberOfOrders = await orderRepository
            .SelectAll(o => !o.IsDeleted && o.CreatedAt <= to && o.CreatedAt >= from && o.PaymentStatus == PaymentStatus.Paid)
            .Select(o => o.Id)
            .CountAsync();

        sellsTable.NumberOfOrderedUsers = await orderRepository
            .SelectAll(o => !o.IsDeleted && o.CreatedAt <= to && o.CreatedAt >= from && o.PaymentStatus == PaymentStatus.Paid)
            .Select(o => o.UserId)
            .Distinct<long>()
            .CountAsync();

        sellsTable.AvarageOrder = sellsTable.SumOfSells / sellsTable.NumberOfOrders;
        sellsTable.From = from;
        sellsTable.To = to;

        return sellsTable;
    }

    public async Task<IEnumerable<TopProductModel>> GetTopProducts(DateTime from, DateTime to, int top = 10)
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
                .SelectAll(o => o.Id == product.Id && !o.IsDeleted && o.CreatedAt <= to && o.CreatedAt >= from)
                .Select(o => o.Amount)
                .SumAsync();
           
            productModel.SumOfSells = productModel.SellsNumber * product.Price;

            allProductModels.Add(productModel);
        }

        allProductModels.OrderByDescending(p => p.SumOfSells);

        var topProductModels = allProductModels.Take(top).ToList();

        foreach (var item in allProductModels)
        {
            item.Product = await productService.RetrieveByIdAsync(item.ProductId);
            item.From = from;
            item.To = to;
        }

        return topProductModels;
    }

    public async Task<IEnumerable<TopUserModel>> GetTopUsers(DateTime from, DateTime to, int top = 10)
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
                .SelectAll(p => p.UserId == userId && !p.IsDeleted && p.CreatedAt <= to && p.CreatedAt >= from)
                .Select(p => p.Amount)
                .SumAsync();

            allUserModels.Add(userModel);
        }

        allUserModels.OrderByDescending(p => p.SumOfAllOrders);

        var topUserModels = allUserModels.Take(top).ToList();

        foreach (var item in allUserModels)
        {
            item.User = await userService.RetrieveByIdAsync(item.UserId);
            item.From = from;
            item.To = to;
            item.AllOrdersNumber = await orderRepository
                .SelectAll(o => o.UserId == item.UserId && !o.IsDeleted && o.PaymentStatus == PaymentStatus.Paid && o.CreatedAt <= to && o.CreatedAt >= from)
                .Select(o => o.Id)
                .CountAsync();
        }

        return topUserModels;
    }
}
