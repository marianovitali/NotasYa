using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Application.DTOs.Auth
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
    }
}
