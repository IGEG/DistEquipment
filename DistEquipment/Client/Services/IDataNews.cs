using DistEquipment.Shared;

namespace DistEquipment.Client.Services
{
    public interface IDataNews
    {
        Task<List<News>> GetNews();
        Task<News> GetNewsByUrl(string Url);
    }
}
