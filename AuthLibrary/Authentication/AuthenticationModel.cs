﻿namespace AuthLibrary.Authentication
{
    public class AuthenticationModel
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public string? Username { get; set; }
        public string Role { get; set; }
    }
}
