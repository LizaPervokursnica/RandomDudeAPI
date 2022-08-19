using Microsoft.AspNetCore.Mvc;
using RandomDudeAPI.Models;
using RandomDudeAPI.Services;

namespace RandomDudeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController
    {
        PersonService _service;
        public PersonController(PersonService service) => _service = service;

        [HttpGet]
        public Human GetPerson() => _service.GetPerson();

        [HttpGet("{count}")]
        public IEnumerable<Human> GetPersons(int count) => _service.GetPersons(count);
    }
}
