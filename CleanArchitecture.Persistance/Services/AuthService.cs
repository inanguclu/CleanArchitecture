using CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Persistance.Services
{
    public sealed class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;

        public AuthService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public Task RegisterAsync(RegisterCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
