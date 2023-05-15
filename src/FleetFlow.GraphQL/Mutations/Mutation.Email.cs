using FleetFlow.Service.Interfaces;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask SendEmailAsync([Service] IEmailService emailService,
            string to, 
            string subject, 
            string message)
        {
            await emailService.SendEmailAsync(to, subject, message);
        }
    }
}
