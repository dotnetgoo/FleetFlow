using FleetFlow.Domain.Enums;
using FleetFlow.GraphQL.Extensions;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<PaymentResultDto> CreatePaymentAsync([Service] IPaymentService paymentService,
            PaymentCreationDto payment, IFile file)
        {

            return await paymentService.AddAsync(payment, await file.ToAttachmentAsync());
        }

        public async ValueTask<PaymentResultDto> ChangePaymentStatusAsync([Service] IPaymentService paymentService,
            long id,
            PaymentStatus status)
        {
            return await paymentService.ChangeStatusAsync(id, status);
        }

        public async ValueTask<PaymentResultDto> UpdatePaymentAsync([Service] IPaymentService paymentService,
            long id,
            PaymentCreationDto dto)
        {
            return await paymentService.ModifyAsync(id, dto);
        }

        public async ValueTask<bool> RemoveAsync([Service] IPaymentService paymentService,
            long id)
        {
            return await paymentService.RemoveAsync(id);
        }
    }
}
