using Microsoft.EntityFrameworkCore;

namespace DroneDelivery.Models.Db
{
    public class DroneDeliveryDbContext:DbContext
    {
        public DroneDeliveryDbContext(DbContextOptions<DroneDeliveryDbContext> options) : base(options) { }

        public DbSet<Drone> Drones { get; set; }
        public DbSet<Medication> Medications { get; set; }

    }
}
