﻿using System.ComponentModel.DataAnnotations;

namespace HMS_Authentication.Models.Dto
{
    public class RegisterResponse
    {
        
        public string Name { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
        
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
