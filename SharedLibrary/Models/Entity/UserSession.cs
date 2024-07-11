namespace SharedLibrary.Models.Entity
{
    public record UserSession(string Id, string Email, string Username, IList<string> roles);
}
