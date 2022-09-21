using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace DistEquipment.Client
{
    public class AuthentificationProvider
    {
        private readonly ILocalStorageService _localStorage;

        public AuthentificationProvider(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }
        public async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
