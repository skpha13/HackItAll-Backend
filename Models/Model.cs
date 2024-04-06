using backend.Models.Base;
using System.Collections.ObjectModel;

namespace HackItAll_Backend.Models
{
    public class Model: BaseEntity
    {
        public string name {  get; set; }

        public Collection<Battery>? batteries { get; set; }

        public Collection<Car>? cars { get; set; }
    }
}
