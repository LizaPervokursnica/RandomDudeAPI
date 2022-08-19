using Microsoft.AspNetCore.Mvc;
using RandomDudeAPI.Models.Place;
using RandomDudeAPI.Services;

namespace RandomDudeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController
    {
        CountryService _countryService;
        public CountryController(CountryService countryService) => _countryService = countryService;

        [HttpGet]
        public IEnumerable<Country> GetAll() => _countryService.GetAll();
    }
}
