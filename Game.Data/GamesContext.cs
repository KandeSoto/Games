using Game.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Game.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options)
        : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
    }
}