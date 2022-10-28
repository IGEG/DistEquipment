using DistEquipment.Server.ModelDto;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.SignalR;
using MimeKit;

namespace DistEquipment.Server.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendMessage(Email email)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(email.From, _configuration.GetSection("EmailName").Value));
            emailMessage.To.Add(new MailboxAddress("", _configuration.GetSection("EmailName").Value));
            emailMessage.Subject = email.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = email.Body
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration.GetSection("EmailHost").Value, Convert.ToInt32(_configuration.GetSection("EmailPort").Value), false);
                await client.AuthenticateAsync(_configuration.GetSection("EmailName").Value, _configuration.GetSection("EmailPassword").Value);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
