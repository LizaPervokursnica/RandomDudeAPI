using RandomDudeAPI.Models.Base;
using System.Text.Json.Serialization;

namespace RandomDudeAPI.Models.Place
{
    public class Country : BaseObject
    {
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Region> Regions { get; set; }
    }
}
