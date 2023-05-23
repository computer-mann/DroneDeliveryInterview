using System.ComponentModel.DataAnnotations;

namespace DroneDelivery.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
