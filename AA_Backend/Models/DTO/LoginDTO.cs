﻿using System.ComponentModel.DataAnnotations;

namespace AA_Backend.Models.DTO
{
    public class LoginDTO
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
