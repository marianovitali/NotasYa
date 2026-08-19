using NotasYa.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto> LoginAsync(LoginRequestDto request);
    }
}
