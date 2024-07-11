using SharedLibrary.Models.Entity;

namespace StudentManager.Server.Services.Contracts
{
    public interface ITokenService
    {
        Task<string> GenerateJwtTokenAsync(UserSession user);
    }
}
