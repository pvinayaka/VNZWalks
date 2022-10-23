using Microsoft.EntityFrameworkCore;
using VNZWalks.API.Models.Domain;

namespace VNZWalks.API.Data
{
    public class VNZWalksDbContext : DbContext
    {
        public VNZWalksDbContext(DbContextOptions<VNZWalksDbContext> options) : base(options)
        {
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
