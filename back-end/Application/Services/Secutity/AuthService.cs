using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Auth;
using Application.Interface.Security;

using Microsoft.EntityFrameworkCore;

namespace Application.Services.Secutity
{
    public class AuthService
    {
        private readonly IEmployeRepository _repo;
        private readonly IEncryptionService _encryption;

        public AuthService(IEmployeRepository repo, IEncryptionService encryption)
        {
            _repo = repo;
            _encryption = encryption;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            // 1. Find user
            var user = await _repo.GetByUserId(request.UserId);

            if (user == null)
            {
                return new LoginResponse
                {
                    Success = false,
                    Message = "User not found"
                };
            }

            // 2. Encrypt password using UserId as key
            var encryptedPassword = _encryption.Encrypt(request.Password, request.UserId);

            // 3. Compare
            if (user.MotPasse != encryptedPassword)
            {
                return new LoginResponse
                {
                    Success = false,
                    Message = "Invalid password"
                };
            }

            return new LoginResponse
            {
                Success = true,
                Message = "Login successful"
            };
        }
    }
}
