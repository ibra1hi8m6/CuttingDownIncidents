using CuttingDownIncidents.Data;
using CuttingDownIncidents.Domain.Entities;
using CuttingDownIncidents.Service.Implementation.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static CuttingDownIncidents.Infrastructure.ViewModel.LoginDTO;

namespace CuttingDownIncidents.Service.Implementation.Servies
{
   

    public class AuthService : IAuthService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(IRepository<User> userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<LoginResultDto> LoginAsync(LoginRequest request)
        {
            var user = await _userRepository
                .FirstOrDefaultAsync(u => u.Name == request.Name && u.Password == request.Password);

            if (user == null)
            {
                return new LoginResultDto
                {
                    Success = false,
                    Message = "Invalid credentials"
                };
            }

            return new LoginResultDto
            {
                Success = true,
                Message = "Login successful",
                UserKey = user.User_Key   // ✅ return UserKey
            };
        }
    }

}
