using RandomDudeAPI.Models.Base;
using RandomDudeAPI.Models.Place;

namespace RandomDudeAPI.Models
{
    public class Human : BaseObject
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public City City { get; set; }
        public string Gender { get; set; }

    }
}
