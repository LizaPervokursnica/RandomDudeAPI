using Microsoft.EntityFrameworkCore;
using RandomDudeAPI.Models.Name;
using RandomDudeAPI.Models.Place;

namespace RandomDudeAPI.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<FirstName> FirstNames { get; set; }
        public DbSet<MiddleName> MiddleNames { get; set; }
        public DbSet<LastName> LastNames { get; set; }
    }
}
