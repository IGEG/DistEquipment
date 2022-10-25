using DistEquipment.Shared;
using System.Net.Http.Json;

namespace DistEquipment.Client.Services
{
    public class DataSolvent : IDataSolvent
    {
        private HttpClient _httpClient;

        public DataSolvent(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Solvent>> GetAllSolvents()
        {
            return await _httpClient.GetFromJsonAsync<List<Solvent>>("api/solvent");
            
        }
    }
}
