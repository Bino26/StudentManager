﻿using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Entity
{
    public class RegisterRequest
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public List<string>? Roles { get; set; }
    }
}
