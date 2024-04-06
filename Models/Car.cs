using backend.Models.Base;
namespace HackItAll_Backend.Models
{
    public class Car : BaseEntity
    {
        public string brand { get; set; }

        public string model { get; set; }

        public Model batteryModel { get; set; }

        public Guid batteryModelId { get; set; }
    }
}
