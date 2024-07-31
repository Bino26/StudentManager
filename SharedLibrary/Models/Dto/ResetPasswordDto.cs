using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Dto
{
    public class ResetPasswordDto
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email field is required")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "New Password field is required")]
        [StringLength(100, MinimumLength = 6)]
        public string newPassword { get; set; } = string.Empty;

        [Compare("newPassword", ErrorMessage = "The new password and confirm password do not match")]
        [StringLength(100, MinimumLength = 6)]
        public string confirmPassword { get; set; } = string.Empty;
    }
}
