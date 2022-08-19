using RandomDudeAPI.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandomDudeAPI.Models.Place
{
    public class City : BaseObject
    {
        public string Name  { get; set; }
    }
}
