using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManager.Server.Services.Contracts;

namespace StudentManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;

        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }
        [HttpPost]
        [Authorize]

        public async Task<IActionResult> SendEmail(string to, string subject, string body)
        {
            try
            {
                await emailService.SendEmailAsync(to, subject, body);
                return Ok($"Email Sent to {to}");
            }
            catch (Exception)
            {
                return BadRequest("Email sending has failed");
            }
        }
    }
}
