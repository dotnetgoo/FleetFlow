using Microsoft.AspNetCore.Http;

namespace FleetFlow.Service.DTOs.Payments;

public class PaymentCreationDto
{
  //  [GraphQLDescription("Amount of paymen (USD)")]
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }
    public long OrderId { get; set; }
    
  //  [GraphQLDescription("Payment invoice file")]
  //  [GraphQLType(typeof(NonNullType<UploadType>))]
    public IFile File { get; set; }
}
