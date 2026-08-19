using System;
using System.Collections.Generic;
using System.Text;

namespace NotasYa.Application.Interfaces
{
    public interface IJwtService
    {
        Task<string> GenerateTokenAsync(
            string userId,
            string email,
            IEnumerable<string> roles);

    }
}
