using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.Entity;
using StudentManager.Server.Data;
using StudentManager.Server.Services.Contracts;

namespace StudentManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {
        private readonly IEmailService emailService;
        private readonly IAuthService authService;
        private readonly StudentDbContext dbContext;

        public InvitationController(IEmailService emailService, IAuthService authService, StudentDbContext dbContext)
        {
            this.emailService = emailService;
            this.authService = authService;
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SendInvitation([FromBody] Invitation request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Email))
                {
                    return BadRequest("Email is required.");
                }

                var token = Guid.NewGuid().ToString();

                var invitation = new Invitation
                {
                    Id = Guid.NewGuid(),
                    Email = request.Email,
                    Token = token,
                    CreatedAt = DateTime.UtcNow,
                    IsUsed = false,

                };

                dbContext.Invitations.Add(invitation);
                await dbContext.SaveChangesAsync();

                var callbackUrl = $"https://localhost:7024/register/invitation?token={token}";
                //var body = $"<a href='{callbackUrl}'>Click here to register</a>";

                string emailContent = $@"
                 Hi there,

We're thrilled to welcome you to our College ! To get started, please click the link below to complete your registration:

Click here to register: <a href='{callbackUrl}'>Invite Registration </a>""

If the link doesn't work, you can copy and paste the following URL into your browser: {callbackUrl}

Looking forward to having you with us!

Best regards,
The Team at Our Service
";

                await emailService.SendEmailAsync(request.Email, "Registration Invitation", emailContent);

                return Ok($"Email sent to {request.Email}");

            }

            catch (Exception)
            {
                return BadRequest($"Email not sent to the user {request.Email}");
            }
        }

    }
}
