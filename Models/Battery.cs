using backend.Models.Base;
using MessagePack;
using System.Text.Json.Serialization;

namespace HackItAll_Backend.Models
{
    public class Battery: BaseEntity
    {
        public Model model { get; set; }
        public Guid modelId { get; set; }
        public int maxCapacity { get; set; }

        public int capacity { get; set; }

        public State state { get; set; }

        [JsonIgnore]
        public Station? station { get; set; }

        public Guid stationId { get; set; }

        public Guid? reservationId { get; set; }

        public Reservation? reservation { get; set; }

       

    }
    public enum State : int
    {
        STORED,
        CHARGING,
        RESERVED
    }
}
