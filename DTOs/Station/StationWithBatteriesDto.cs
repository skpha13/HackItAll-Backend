using HackItAll_Backend.DTOs.Battery;
using System.Collections.ObjectModel;

namespace HackItAll_Backend.DTOs.Station
{
    public class StationWithBatteriesDto
    {
        public float coordinateX {  get; set; }
        public float coordinateY { get; set; }

        public string address { get; set; }

        public int chargingStations { get; set; }

        public Collection<BatteryDto> batteries { get; set; }
    }
}
