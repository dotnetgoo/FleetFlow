using AutoMapper;
using FleetFlow.Domain.Enums;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using Microsoft.EntityFrameworkCore;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Service.Interfaces.Users;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.Interfaces.Orders;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Service.Interfaces.Attachments;
using FleetFlow.Shared.Helpers;

namespace FleetFlow.Service.Services.Orders;

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
        UserForResultDto user = await userService.RetrieveByIdAsync(dto.UserId);
        Order order = await orderRepository.SelectAsync(t => t.Id == dto.OrderId);
        Attachment file = await attachmantService.UploadAsync(attachment);

        Payment payment = new Payment
        {
            Amount = dto.Amount,
            Description = dto.Description,
            Status = PaymentStatus.Pending,
            IsAdmin = dto.IsAdmin
        };
        payment.Attachment.FilePath = file.FilePath;
        payment.Attachment.FileName = file.FileName;
        payment.UserId = (long)HttpContextHelper.UserId;
        payment.Order = order;

        var result = paymentRepository.InsertAsync(payment);
        await paymentRepository.SaveAsync();

        return mapper.Map<PaymentResultDto>(payment);
    }

    public async Task<PaymentResultDto> ChangeStatusAsync(long id, PaymentStatus status)
    {
        Payment payment = await paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");

        payment.Status = status;
        payment = paymentRepository.Update(payment);
        await paymentRepository.SaveAsync();

        return mapper.Map<PaymentResultDto>(payment);
    }

    public async Task<PaymentResultDto> ModifyAsync(long id, PaymentCreationDto dto)
    {
        Payment payment = await paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");

        Payment mappedPayment = mapper.Map<Payment>(dto);
        mappedPayment.Id = id;
        mappedPayment.UpdatedAt = DateTime.UtcNow;
        mappedPayment.CreatedAt = payment.CreatedAt;
        payment = paymentRepository.Update(payment);
        await paymentRepository.SaveAsync();

        return mapper.Map<PaymentResultDto>(payment);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        Payment payment = await paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");

        await paymentRepository.DeleteAsync(t => t.Id == id);
        await paymentRepository.SaveAsync();
        return true;
    }

    public async Task<IEnumerable<PaymentResultDto>> RetrieveAllAsync(PaginationParams @params = null)
    {
        var payments = await paymentRepository.SelectAll().ToPagedList(@params).ToListAsync();
        return mapper.Map<IEnumerable<PaymentResultDto>>(payments);
    }

    public async Task<PaymentResultDto> RetrieveByIdAsync(long id)
    {
        Payment payment = await paymentRepository.SelectAsync(t => t.Id == id);
        if (payment is null)
            throw new FleetFlowException(404, "Payment is not found");
        return mapper.Map<PaymentResultDto>(payment);
    }
}
