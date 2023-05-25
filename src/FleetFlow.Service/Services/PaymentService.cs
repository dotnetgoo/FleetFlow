using AutoMapper;
using FleetFlow.Domain.Enums;
using FleetFlow.Domain.Entities;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using Microsoft.EntityFrameworkCore;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.DTOs.Attachments;

namespace FleetFlow.Service.Services;

public class PaymentService : IPaymentService
{
    private readonly IMapper mapper;
    private readonly IUserService userService;
    private readonly IRepository<Order> orderRepository;
    private readonly IAttachmentService attachmantService;
    private readonly IRepository<Payment> paymentRepository;
    public PaymentService(
        IMapper mapper,
        IUserService userService,
        IRepository<Order> orderRepository,
        IAttachmentService attachmantService,
        IRepository<Payment> paymentRepository)
    {
        this.mapper = mapper;
        this.userService = userService;
        this.orderRepository = orderRepository;
        this.attachmantService = attachmantService;
        this.paymentRepository = paymentRepository;
    }

    public async Task<PaymentResultDto> AddAsync(PaymentCreationDto dto, AttachmentCreationDto attachment)
    {
        UserForResultDto user = await this.userService.RetrieveByIdAsync(dto.UserId);
        Order order = await this.orderRepository.SelectAsync(t => t.Id == dto.OrderId);
        Attachment file = await this.attachmantService.UploadAsync(attachment);

        PaymentResultDto result = new PaymentResultDto
        {
            Amount = dto.Amount,
            Description = dto.Description,
            FilePath = file.FilePath,
            Order = this.mapper.Map<OrderResultDto>(order),
            User = user,
            Status = PaymentStatus.Pending
        };
        return result;
    }

    public async Task<PaymentResultDto> ChangeStatusAsync(long id, PaymentStatus status)
    {
        Payment payment = await this.paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");

        payment.Status = status;
        payment = this.paymentRepository.Update(payment);
        await this.paymentRepository.SaveAsync();

        return this.mapper.Map<PaymentResultDto>(payment);
    }

    public async Task<PaymentResultDto> ModifyAsync(long id, PaymentCreationDto dto)
    {
        Payment payment = await this.paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");

        Payment mappedPayment = this.mapper.Map<Payment>(dto);
        mappedPayment.Id = id;
        mappedPayment.UpdatedAt = DateTime.UtcNow;
        mappedPayment.CreatedAt = payment.CreatedAt;
        payment = this.paymentRepository.Update(payment);
        await this.paymentRepository.SaveAsync();

        return this.mapper.Map<PaymentResultDto>(payment);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        Payment payment = await this.paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");

        await this.paymentRepository.DeleteAsync(t => t.Id == id);
        await this.paymentRepository.SaveAsync();
        return true;
    }

    public async Task<IEnumerable<PaymentResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var payments = await this.paymentRepository.SelectAll().ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<PaymentResultDto>>(payments);
    }

    public async Task<PaymentResultDto> RetrieveByIdAsync(long id)
    {
        Payment payment = await this.paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");
        return this.mapper.Map<PaymentResultDto>(payment);
    }
}
