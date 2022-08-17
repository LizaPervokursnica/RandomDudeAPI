using RandomDudeAPI.Models.Base;
using RandomDudeAPI.Models.Enums;

namespace RandomDudeAPI.Models.Name
{
    public class FirstName : BaseObject
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
