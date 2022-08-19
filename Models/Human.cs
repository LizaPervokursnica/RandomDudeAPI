namespace RandomDudeAPI.Models
{
    public class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public Adress Adress { get; set; }
    }
}
