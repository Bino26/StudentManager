using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Dto
{
    public class ResetPassword
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email field is required")]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Token { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
    }
}
