namespace RestfulAPI.Domain.Authentication;
public class RegistrationResult
{
    public string Token { get; set; }
    public bool Success { get; set; }
    public string Error { get; set; }
}
