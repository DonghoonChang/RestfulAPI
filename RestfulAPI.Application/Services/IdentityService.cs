using Microsoft.AspNetCore.Identity;
using RestfulAPI.Domain.Authentication;
using RestfulAPI.Domain.User;

namespace RestfulAPI.Application.Services;
public class IdentityService: IIdentityService
{
    private readonly UserManager<User> _userManager;

    public IdentityService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<RegistrationResult> Register(string email, string password)
    {
        var existing = await _userManager.FindByEmailAsync(email);
        throw new NotImplementedException();
    }
}
