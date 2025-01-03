﻿using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models.Entity
{
    public class LoginRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
