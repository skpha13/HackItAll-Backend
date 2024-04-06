using HackItAll_Backend.DTOs.Model;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.DTOs.Battery
{
    public class BatteryDto
    {
        public Guid id { get; set; }
        public ModelDto modelDto { get; set; }

        public int maxCapacity { get; set; }

        public int capacity { get; set; }

        public State state { get; set; }

        public float percentage { get; set; }
       
    }
}
