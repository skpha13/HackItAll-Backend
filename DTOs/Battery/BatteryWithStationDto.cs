using HackItAll_Backend.DTOs.Model;
using HackItAll_Backend.DTOs.Station;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.DTOs.Battery
{
    public class BatteryWithStationDto
    {
        public ModelDto model { get; set; }
        public int maxCapacity { get; set; }
        public int capacity { get; set; }
        public int expectedRange { get { return 400 * capacity / maxCapacity; } }

        public State state { get; set; }

        public StationDto station { get; set; }

        public int chargingTime {
            get
            {
                return 60 * (maxCapacity - capacity) / maxCapacity;
            }  }
    }
}
