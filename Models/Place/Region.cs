using RandomDudeAPI.Models.Base;
using System.Text.Json.Serialization;

namespace RandomDudeAPI.Models.Place
{
    public class Region : BaseObject
    {
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<City> Cities { get; set; }

        public Country Country { get; set; }
    }
}
