using RandomDudeAPI.Models.Enums;

namespace RandomDudeAPI.Methods
{
    public class EnumValue
    {
        public static Gender GetGenderValue()
        {
            var values = Enum.GetValues(typeof(Gender));
            return (Gender)values.GetValue(Random.Shared.Next(values.Length));
        }
    }
}
