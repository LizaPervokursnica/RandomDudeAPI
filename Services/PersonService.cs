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

            var lastName = SelectName.GetLastName(_context, gender);

            return new Human { 
                Id = 1, 
                City = firstCity, 
                FirstName = SelectName.GetFirstName(_context, gender).TrimEnd(), 
                LastName = lastName, 
                MiddleName = SelectName.GetMiddleName(_context, gender),
                Birthdate = PersonBorn.GetBirthdate(),
                Email = PersonContact.GetEmail(lastName),
                PhoneNumber = PersonContact.GetPhone(),
                Gender = TranslateEnum.GetDescription(gender)
            };
        }

        public IEnumerable<Human> GetPersons(int count)
        {
            var persons = new List<Human>();
            for (int i = 0; i <= count; i++)
            {
                persons.Add(GetPerson());
            }
            return persons;
        }
    }
}
