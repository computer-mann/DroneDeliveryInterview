using DroneDelivery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroneDelivery.DbConfigurations
{
    public class MedicationDbConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
          //  builder.Property(p => p.RowVersion).IsRowVersion();
        }
    }
}
