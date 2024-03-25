using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpeedySend.Infra.Services;
using SpeedySend.ViewModels;

namespace SpeedySend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEMailService _emailService;
        public EmailController(IEMailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult EnvioEmail([FromBody] EnvioEmailViewModel envioEmailViewModel)
        {
            _emailService.EnviaEmail(envioEmailViewModel.Emails, envioEmailViewModel.Subject, envioEmailViewModel.Body, envioEmailViewModel.IsHtml);
            return Ok();
        }
    }
}
