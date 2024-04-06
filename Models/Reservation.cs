
using backend.Models.Base;

namespace HackItAll_Backend.Models
{
    public class Reservation: BaseEntity
    {
        public string name {  get; set; }
        public Guid batteryId { get; set; }
        public Battery battery { get; set; }
    }
}
