namespace StudentManager.Server.Services.Contracts
{
    public interface ITokenService
    {
        Task<string> GenerateJwtTokenAsync(string Email, IList<string> roles);
    }
}
