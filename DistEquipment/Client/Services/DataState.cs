using Blazored.LocalStorage;

namespace DistEquipment.Client.Services
{
    public class DataState : IDataState
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public DataState(HttpClient httpClient,ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }
        public async Task AddVisit()
        {
            DateTime? lastVisit = await _localStorage.GetItemAsync<DateTime>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await _httpClient.PostAsync("api/state",null);
            }
        }

        public async Task GetVisits()
        {
            var visit = int.Parse( await _httpClient.GetStringAsync("api/state"));
            Console.WriteLine($"visits:{visit}");

        }
    }
}
