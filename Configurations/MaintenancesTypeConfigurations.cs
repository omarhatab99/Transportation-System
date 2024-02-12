using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    
        public partial class MaintenancesTypeConfigurations : IEntityTypeConfiguration<Maintenance>
        {
            public void Configure(EntityTypeBuilder<Maintenance> builder)
            {

                //PK
                builder.HasKey(x => x.Id);

                //Relations 
                // 1 (driver) - M (Maintenances) --> Done in the Drivers  Configurations
                // 1 (Vehicle) - M (Maintenances) --> Done in the Vehicle  Configurations


                //Index
                builder.HasIndex(x => x.DriverId);
                builder.HasIndex(x => x.VechieId);
                builder.HasIndex(x => x.TripId);




            //Constrains
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");






            }
        }
    }


