using RandomDudeAPI.Data;
using RandomDudeAPI.Methods;
using RandomDudeAPI.Models;

namespace RandomDudeAPI.Services
{
    public class PersonService
    {
        private readonly PersonContext _context;
        public PersonService(PersonContext context) => _context = context; 
        
        public Human GetPerson()
        {
            var gender = EnumValue.GetGenderValue();
            
            var lastName = SelectName.GetLastName(_context, gender);
            return new Human { 
                Adress = PersonAdress.GetAdress(_context), 
                FirstName = SelectName.GetFirstName(_context, gender).TrimEnd(), 
                LastName = lastName, 
                MiddleName = SelectName.GetMiddleName(_context, gender),
                Birthdate = PersonBorn.GetBirthdate().ToString("d"),
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
