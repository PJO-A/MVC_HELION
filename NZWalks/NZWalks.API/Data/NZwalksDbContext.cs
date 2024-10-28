using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZwalksDbContext :DbContext
    {
        // class constructor
        public NZwalksDbContext(DbContextOptions dbContectOptions): base(dbContectOptions)
        {
            
        }

        //DBSETS - properties of DBContext class, whcih represents collection of entities in database
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }



    }
      
}
