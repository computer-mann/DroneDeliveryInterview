using DroneDelivery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroneDelivery.DbConfigurations
{
    public class DroneDbConfiguration : IEntityTypeConfiguration<Drone>
    {
        public void Configure(EntityTypeBuilder<Drone> builder)
        {
           // builder.Property(p => p.RowVersion).IsRowVersion();
        }
    }
}
