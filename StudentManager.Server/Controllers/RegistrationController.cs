using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models.Entity;
using StudentManager.Server.Data;
using StudentManager.Server.Services.Contracts;

namespace StudentManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IEmailService emailService;
        private readonly IAuthService authService;
        private readonly StudentDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public RegistrationController(IEmailService emailService, IAuthService authService, StudentDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.emailService = emailService;
            this.authService = authService;
            this.dbContext = dbContext;
            this.userManager = userManager;
        }


        [HttpGet]
        [Route("getmail")]
        // GET: /api/registration/getmail/invitat?token=token

        public async Task<IActionResult> GetInviteMail([FromQuery] string token)
        {
            var invitation = await dbContext.Invitations.FirstOrDefaultAsync(i => i.Token == token);
            if (invitation == null)
            {
                return BadRequest("Invalid token.");
            }
            return Ok(invitation.Email);
        }

        [HttpPost]
        [Route("register/invitation")]
        // POST: /api/registration/register/invitation?token=token
        public async Task<IActionResult> RegistrationByInvitation([FromQuery] string token, [FromBody] InviteRegistration inviteDto)
        {
            try
            {
                var invitation = await dbContext.Invitations.FirstOrDefaultAsync(i => i.Token == token && !i.IsUsed);
                if (invitation == null)
                {
                    return BadRequest("Invalid or expired token.");
                }
                var existingUser = await userManager.FindByEmailAsync(invitation.Email);
                if (existingUser is not null)
                {
                    return BadRequest("User already exists");
                }
                var user = new ApplicationUser
                {
                    UserName = inviteDto.Username,
                    Email = invitation.Email
                };

                var result = await userManager.CreateAsync(user, inviteDto.Password);
                if (result.Succeeded)

                {

                    var roles = inviteDto.Roles ?? new List<string>();
                    roles.Add("Student");
                    result = await userManager.AddToRolesAsync(user, roles);

                }
                if (result.Succeeded)
                {
                    invitation.IsUsed = true;
                    await dbContext.SaveChangesAsync();
                    return Ok("User Registred");
                }
                return BadRequest("Your Token is invalid");
            }
            catch (Exception)
            {
                return BadRequest("Registration failed");
            }


        }


    }
}
