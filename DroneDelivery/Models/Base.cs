using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneDelivery.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        
        public byte[] RowVersion { get; set; }
        
    }
}
