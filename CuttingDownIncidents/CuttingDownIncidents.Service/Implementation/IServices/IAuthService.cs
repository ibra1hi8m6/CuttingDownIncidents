using CuttingDownIncidents.Domain.Entities;
using Microsoft.AspNetCore.Http.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static CuttingDownIncidents.Infrastructure.ViewModel.LoginDTO;

namespace CuttingDownIncidents.Service.Implementation.IServices
{
    public interface IAuthService
    {
        Task<LoginResultDto> LoginAsync(LoginRequest request);
    }
}
