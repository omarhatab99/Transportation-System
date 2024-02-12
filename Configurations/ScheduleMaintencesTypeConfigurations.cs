using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class ScheduleMaintencesTypeConfigurations : IEntityTypeConfiguration<ScheduleMaintence>
    {
        public void Configure(EntityTypeBuilder<ScheduleMaintence> builder)
        {

            //PK
            builder.HasKey(x => x.Id);

            //Relations 
            // 1 (vehicle) - M (ScheduleMaintence) --> Done in the Vehicle Configrations     

            //Index
            builder.HasIndex(x => new {x.VechieId , x.MainteneceDateStart});
            builder.HasIndex(x => x.VechieId);

            //Constraints
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");



        }
    }

}
