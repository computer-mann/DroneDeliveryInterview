using DroneDelivery.Models;
using System.ComponentModel.DataAnnotations;

namespace DroneDelivery.ViewModels
{
    public class CreateDroneViewModel
    {
        [MaxLength(100)]
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        [Range(0, 500)]
        public double WeightLimit { get; set; }
        public State State { get; set; }
        [Range(0, 100)]
        public int BatteryCapacity { get; set; }
    }
    public class EditDroneViewModel
    {
    }
    public class DeleteDroneViewModel
    {
    }
  
}
