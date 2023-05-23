using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DroneDelivery.Models
{
    public class Drone:Base
    {
        [MaxLength(100)]
        public string SerialNumber { get; set; }
        public Model Model { get; set; }
        [Range(0, 500)]
        public double WeightLimit { get; set; }
        public State State { get; set; }
        [Range(0,100)]
        public int BatteryCapacity { get; set; }

    }
    public enum State
    {
        IDLE, LOADING, LOADED, DELIVERING, DELIVERED, RETURNING
    }

    public enum Model
    {
        Lightweight, Middleweight, Cruiserweight, Heavyweight
    }
}
