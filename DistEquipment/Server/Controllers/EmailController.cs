using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using MimeKit.Text;
using DistEquipment.Server.Services;
using DistEquipment.Server.ModelDto;
using DistEquipment.Shared;

namespace DistEquipment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailServices;

        public EmailController(IEmailService emailService)
        {
            _emailServices = emailService;
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(FeedBackForm feedBackForm)
        {
            Email email = new Email() { From = "sa", Subject = "sd", Body = $"{feedBackForm.Name}" };
            await _emailServices.SendMessage(email);
            return Ok();
        }

        }
    }

