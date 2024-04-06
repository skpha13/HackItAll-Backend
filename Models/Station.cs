using backend.Models.Base;
using System.Collections.ObjectModel;

namespace HackItAll_Backend.Models
{
    public class Station : BaseEntity
    {
        public float coordinateX {  get; set; }
        public float coordinateY { get; set; }

        public string address { get; set; }

        public int chargingStations { get; set; }

        public Collection<Battery>? batteries {  get; set; }


    }
}
