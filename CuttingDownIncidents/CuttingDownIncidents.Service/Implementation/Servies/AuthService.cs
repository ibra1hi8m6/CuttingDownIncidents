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
            // Validate user
            var user = await _userRepository
                .FirstOrDefaultAsync(u => u.Name == request.Name && u.Password == request.Password);

            if (user == null)
            {
                return new LoginResultDto
                {
                    Success = false,
                    Message = "Invalid username or password"
                };
            }

            // Create claims
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Name),
            new Claim("User_Key", user.User_Key.ToString())
        };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(2)
            };

            // Sign in using HttpContext
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                return new LoginResultDto
                {
                    Success = false,
                    Message = "Failed to sign in"
                };
            }

            await httpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return new LoginResultDto
            {
                Success = true,
                Message = "Login successful"
            };
        }
    }

}
