using VNZWalks.API.Models.Domain;

namespace VNZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAll();
    }
}
