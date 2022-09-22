using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace DistEquipment.Client
{
    public class AuthentificationProvider: AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;

        public AuthentificationProvider(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            string name = await _localStorage.GetItemAsStringAsync("username");
            if (!String.IsNullOrEmpty(name))
            { 
            var identity = new ClaimsIdentity(
               new[] { new Claim(ClaimTypes.Name,name)},"test autetificatin");
                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
                
        }
    }
}
