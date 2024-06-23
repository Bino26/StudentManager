using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name field is required")]
        [MinLength(3, ErrorMessage = "Name must contains at least 3 characters")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Class field is required")]
        public string Class { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email field is required")]
        public string Email { get; set; } = string.Empty;

    }
}
