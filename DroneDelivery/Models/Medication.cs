using System.ComponentModel.DataAnnotations;

namespace DroneDelivery.Models
{
    public class Medication:Base
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9_-]*$")]
        public string Name { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        [RegularExpression("^[A-Z0-9_]*$")]
        public string Code { get; set; }
        [Required]
        public string Image { get; set; }

    }
}
