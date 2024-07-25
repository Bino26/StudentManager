using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models.Dto;
using SharedLibrary.Models.Entity;
using StudentManager.Server.CustomActionFilters;
using StudentManager.Server.Data;
using StudentManager.Server.Services.Contracts;
using System.Text.Encodings.Web;

namespace StudentManager.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly IEmailService emailService;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(IAuthService authService, IEmailService emailService, UserManager<ApplicationUser> userManager)
        {
            this.authService = authService;
            this.emailService = emailService;
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        [ValidateModel]

        public async Task<IActionResult> Register([FromBody] RegisterRequest createUserDto)
        {
            var user = await authService.CreateUserAsync(createUserDto);
            if (user != false)
            {
                return Ok("User registred successfuly");
            }
            return BadRequest("Something went wrong");
        }

        [HttpPost]
        [Route("login")]

        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequestDto)
        {
            var loginResponse = await authService.LoginAsync(loginRequestDto);
            if (loginResponse == null || string.IsNullOrEmpty(loginResponse.JwtToken))
            {
                return BadRequest("Your password or username is incorrect");

            }

            return Ok(loginResponse);

        }

        [HttpGet]
        [Authorize(Roles = "Admin,Student")]
        [Route("user")]

        public async Task<IActionResult> GetUser()
        {
            var result = await authService.GetUserAsync(User);
            return result;
        }

        [HttpGet]
        [Authorize(Roles = "Student,Admin")]
        [Route("logout")]

        public async Task<IActionResult> LogOut()
        {
            await authService.LogOutAsync();
            return Ok("User was logged out successfuly");
        }
        //[HttpPut]
        //[Authorize(Roles = "Writer,Reader")]
        //[Route("updateuser")]

        ////public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto updateUserDto)
        ////{
        ////    var result = await authService.UpdateAsync(updateUserDto, User);
        ////    return result;
        ////}

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        [Route("deleteuser")]

        public async Task<IActionResult> DeleteUser()
        {
            var result = await authService.DeleteUserAsync(User);
            return result;
        }

        [HttpPost]
        [Route("forgotpassword")]
        [ValidateModel]

        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPassword model)
        {

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return BadRequest("User not found");

            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = $"https://localhost:7024/resetpassword?token={token}";

            await emailService.SendEmailAsync(model.Email, "Reset Password", $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            return Ok("Password reset link has been sent to your email.");
        }

        [HttpPost]
        [Route("ResetPassword")]
        [ValidateModel]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword model)
        {

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return BadRequest("User not found");

            var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
                return Ok("Password has been reset successfully");

            return Ok("Password reset successfuly.");

        }
    }


}

