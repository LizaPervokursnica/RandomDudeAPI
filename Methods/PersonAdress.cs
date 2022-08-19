using Microsoft.EntityFrameworkCore;
using RandomDudeAPI.Data;
using RandomDudeAPI.Models;

namespace RandomDudeAPI.Methods
{
    public class PersonAdress
    {
        public static Adress GetAdress(PersonContext context)
        {
            var regionIds = context.Regions.Include(x => x.Cities).Where(x => x.Cities.Any()).Select(x => x.Id).ToArray();
            var regionId = regionIds[Random.Shared.Next(regionIds.Length)];
            var region = context.Regions.Include(x => x.Cities).Include(x => x.Country).First(x => x.Id == regionId);
            
          
                region = context.Regions.Include(x => x.Cities).Include(x => x.Country).First(x => x.Id == regionId);
            
            var regionCitiyIds = region.Cities.Select(x => x.Id).ToArray();
            
            var cityId = regionCitiyIds[Random.Shared.Next(regionCitiyIds.Length)];
            var city = context.Cities.First(x => x.Id == cityId);

            return new Adress { City = city.Name, Region = region.Name, Country = region.Country.Name };
        }
    }
}
