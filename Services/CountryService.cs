using RandomDudeAPI.Data;
using RandomDudeAPI.Models.Place;

namespace RandomDudeAPI.Services
{
    public class CountryService
    {
        private readonly PersonContext _context;

        public CountryService(PersonContext context)
        {
             _context = context;
        }

        public IEnumerable<Country> GetAll() => _context.Countries.ToList();
    }
}
