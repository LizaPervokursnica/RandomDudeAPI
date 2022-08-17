using Microsoft.EntityFrameworkCore;
using RandomDudeAPI.Data;
using RandomDudeAPI.Models.Place;

namespace RandomDudeAPI.Services
{
    public class CityService
    {
        private readonly PersonContext _context;
        public CityService(PersonContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetAll() => _context.Cities.ToList();
        public City? GetById(int id) => _context.Cities.SingleOrDefault(c => c.Id == id);
        public City Create(City newCity)
        {
            _context.Cities.Add(newCity);
            _context.SaveChanges();

            return newCity;
        }

        //public void DeleteById(int id)
        //{
        //    var cityToDelete = _context.Cities.Find(id);
        //    if (cityToDelete is not null)
        //    {
        //        _context.Cities.Remove(cityToDelete);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
