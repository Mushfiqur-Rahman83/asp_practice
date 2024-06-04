using asp.api.models.domain;
using Microsoft.EntityFrameworkCore;

namespace asp.api.Data
{
    public class NZWalksDBContext: DbContext
    {
        public NZWalksDBContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {
                
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions {  get; set; }
        public DbSet<Walk> Walks { get; set; }

    }
}
