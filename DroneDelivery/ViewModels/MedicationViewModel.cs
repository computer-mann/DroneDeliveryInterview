using System.ComponentModel.DataAnnotations;

namespace DroneDelivery.ViewModels
{
    public class CreateMedicationViewModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9_-]*$"),MinLength(4)]
        public string Name { get; set; }
        [Required]
        public double Weight { get; set; }
        public string Image { get; set; } //change to iformfile later
        [Required,MinLength(4)]
        [RegularExpression("^[A-Z0-9_]*$")]
        public string Code { get; set; }
    }

    public class EditMedicationViewModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9_-]*$")]
        public string Name { get; set; }
        [Required]
        public double Weight { get; set; }
        public string Image { get; set; } //change to iformfilelater
        [Required]
        [RegularExpression("^[A-Z0-9_]*$")]
        public string Code { get; set; }
}
}
