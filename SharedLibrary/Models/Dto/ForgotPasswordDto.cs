using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Dto
{
    public class ForgotPasswordDto
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;
    }
}
