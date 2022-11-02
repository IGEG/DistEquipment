using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using MimeKit.Text;
using DistEquipment.Server.Services;
using DistEquipment.Server.ModelDto;
using DistEquipment.Shared;
using AutoMapper;

namespace DistEquipment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailServices;
        private readonly IMapper _mapper;

        public EmailController(IEmailService emailService, IMapper mapper)
        {
            _emailServices = emailService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(FeedBackForm feedBackForm)
        {
            var email = _mapper.Map<Email>(feedBackForm);
            await _emailServices.SendMessage(email);
            return Ok();
        }

        }
    }

