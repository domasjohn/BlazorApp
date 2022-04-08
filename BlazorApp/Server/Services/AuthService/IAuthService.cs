using BlazorApp.Shared;

namespace BlazorApp.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserAuth user, string password);

        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> Login(string email, string password);
    }
}
