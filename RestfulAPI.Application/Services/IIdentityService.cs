using RestfulAPI.Domain.Authentication;

namespace RestfulAPI.Application.Services;

public interface IIdentityService
{
    Task<RegistrationResult> Register(string username, string password);
}
