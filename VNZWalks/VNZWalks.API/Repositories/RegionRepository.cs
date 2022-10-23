using Microsoft.EntityFrameworkCore;
using VNZWalks.API.Data;
using VNZWalks.API.Models.Domain;

namespace VNZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly VNZWalksDbContext _vNZWalksDbContext;

        public RegionRepository(VNZWalksDbContext vNZWalksDbContext)
        {
            this._vNZWalksDbContext = vNZWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAll()
        {
            return await _vNZWalksDbContext.Regions.ToListAsync();
        }
    }
}
