namespace RandomDudeAPI.Methods
{
    public class PersonBorn
    {
        public static DateTime GetBirthdate() => DateTime.Now.Date.AddYears(Random.Shared.Next(-80, -18)).AddDays(Random.Shared.Next(0, 365));                           
    }
}
