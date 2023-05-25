using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Payments;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IPaymentService
{
    Task<PaymentResultDto> AddAsync(PaymentCreationDto dto, AttachmentCreationDto attachment);
    Task<bool> RemoveAsync(long id);
    Task<PaymentResultDto> ModifyAsync(long id, PaymentCreationDto dto);
    Task<IEnumerable<PaymentResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<PaymentResultDto> RetrieveByIdAsync(long id);
    Task<PaymentResultDto> ChangeStatusAsync(long id, PaymentStatus status);
}
