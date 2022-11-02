using DistEquipment.Shared;

namespace DistEquipment.Server.Data
{
    public interface IDataNews
    {
        Task<List<News>> GetNews();
        Task<News> GetNewsByURL(string Url);
    }
}
