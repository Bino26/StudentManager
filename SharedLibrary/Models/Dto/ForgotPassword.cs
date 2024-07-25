using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Dto
{
    public class ForgotPassword
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email field is required")]
        public string Email { get; set; } = string.Empty;
    }
}
