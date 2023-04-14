using FleetFlow.Service.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace FleetFlow.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration.GetSection("Email");
        }


        public async Task SendEmailAsync(string to, string subject, string message)
        {
            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse(configuration["EmailAddress"]));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart("html") { Text = message };

            var smtp = new SmtpClient();
            await smtp.ConnectAsync(configuration["Host"], 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(configuration["EmailAddress"], configuration["Password"]);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);

        }
    }
}
