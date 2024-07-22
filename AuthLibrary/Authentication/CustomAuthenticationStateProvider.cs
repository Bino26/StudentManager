using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;

namespace AuthLibrary.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorageService;
        private ClaimsPrincipal anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var authenticationModel = await localStorageService.GetItemAsStringAsync("Authentication");
                if (authenticationModel == null)
                {
                    return await Task.FromResult(new AuthenticationState(anonymous));
                }

                var user = Deserialize(authenticationModel);
                var claimsPrincipal = SetClaims(user.Username!, user.Role!);
                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(anonymous));
            }
        }

        public async Task UpdateAuthenticationState(AuthenticationModel authenticationModel)
        {
            try
            {
                ClaimsPrincipal claimsPrincipal = new();
                if (authenticationModel != null)
                {
                    claimsPrincipal = SetClaims(authenticationModel.Username, authenticationModel.Role);
                    await localStorageService.SetItemAsStringAsync("Authentication", Serialize(authenticationModel));
                }
                else
                {
                    await localStorageService.RemoveItemAsync("Authentication");
                    claimsPrincipal = anonymous;
                }
                NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
            }
            catch
            {

                await Task.FromResult(new AuthenticationState(anonymous));
            }
        }

        private ClaimsPrincipal SetClaims(string username, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };


            var identity = new ClaimsIdentity(claims, "CustomAuth");
            return new ClaimsPrincipal(identity);
        }

        private AuthenticationModel Deserialize(string serializeString)
        {
            return JsonSerializer.Deserialize<AuthenticationModel>(serializeString);
        }

        private string Serialize(AuthenticationModel model)
        {
            return JsonSerializer.Serialize(model);
        }
    }
}
