using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Entity
{
    public class InviteRegistration
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public List<string>? Roles { get; set; }
    }
}
