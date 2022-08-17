using RandomDudeAPI.Data;
using RandomDudeAPI.Models.Enums;

namespace RandomDudeAPI.Methods
{
    public class SelectName
    {
        public static string GetFirstName(PersonContext context, Gender gender)
        {
            var names = context.FirstNames.Where(x => x.Gender == gender).ToList();
            return names[Random.Shared.Next(0, names.Count)].Name;

        }
        public static string GetMiddleName(PersonContext context, Gender gender)
        {
            var surnames = context.MiddleNames.ToList();
            var surname = surnames[Random.Shared.Next(0, surnames.Count)].Value;

            return gender == Gender.Male ? surname : TransformMiddleName(surname);

        }
        public static string GetLastName(PersonContext context, Gender gender)
        {
            var lastnames = context.LastNames.ToList();
            var lastname = lastnames[Random.Shared.Next(0, lastnames.Count)].Value;

            return gender == Gender.Male ? lastname : TransformLastName(lastname);
        }

        private static string TransformMiddleName(string middleName)
        {
            if (middleName.EndsWith("вич"))
                return middleName.Replace("вич", "вна");
            if (middleName.EndsWith("ич"))
                return middleName.Replace("ич", "ична");
            return middleName;
        }

        private static string TransformLastName(string lastname)
        {
            if (lastname.EndsWith("ый") || lastname.EndsWith("ий"))
                return lastname.Remove(lastname.Length - 3) + "ая";
            if (lastname.EndsWith("ов") || lastname.EndsWith("ев") || lastname.EndsWith("ин") || lastname.EndsWith("ёв"))
                return lastname + "а";
            return lastname;
        }
    }
}
