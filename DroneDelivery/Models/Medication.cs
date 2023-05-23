using System.ComponentModel.DataAnnotations;

namespace DroneDelivery.Models
{
    public class Medication:Base
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        [Reg]
        public string Code { get; set; }
        [Required]
        public string Image { get; set; }
        name(allowed only letters, numbers, ‘-‘, ‘_’);
        weight;
code(allowed only upper case letters, underscore and numbers);
    }
}
