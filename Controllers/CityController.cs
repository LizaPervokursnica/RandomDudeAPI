using Microsoft.AspNetCore.Mvc;
using RandomDudeAPI.Models.Place;
using RandomDudeAPI.Services;

namespace RandomDudeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        CityService _cityService;
        public CityController(CityService service)
        {
            _cityService = service;
        }

        [HttpGet]
        public IEnumerable<City> GetAll() => _cityService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<City> GetById(int id)
        {
            var city = _cityService.GetById(id);
            return city is not null ? city : NotFound();
        }
    }
}
