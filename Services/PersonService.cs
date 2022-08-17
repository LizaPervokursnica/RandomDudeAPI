using RandomDudeAPI.Data;
using RandomDudeAPI.Methods;
using RandomDudeAPI.Models;
using RandomDudeAPI.Models.Enums;
using System;

namespace RandomDudeAPI.Services
{
    public class PersonService
    {
        private readonly PersonContext _context;
        public PersonService(PersonContext context)
        {
            _context = context; 
        }

        public Human GetPerson()
        {
            var gender = EnumValue.GetGenderValue();
            var firstCity = _context.Cities.First();


            return new Human { 
                Id = 1, 
                City = firstCity, 
                FirstName = SelectName.GetFirstName(_context, gender), 
                LastName = SelectName.GetLastName(_context, gender), 
                MiddleName = SelectName.GetMiddleName(_context, gender),
                Birthdate = DateTime.Now,
                Email = "asfqasf@asdgt.re", 
                PhoneNumber = "8124124",
                Gender = TranslateEnum.GetDescription(gender)
            };
        }
    }
}
