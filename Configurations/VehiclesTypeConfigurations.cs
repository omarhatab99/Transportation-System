using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class VehiclesTypeConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            //PK
            builder.HasKey(x => x.Id);


            //Relations 
            //One(vehicle) to Many(Schaduled Maintinance)
            builder.HasMany(x => x.ScheduleMaintences)
                .WithOne(x => x.Vehicle)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.VechieId)
                .IsRequired();

            //One(vehicle) to Many(Maintinance)
            builder.HasMany(x => x.Maintenances)
                .WithOne(x => x.Vehicle)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.VechieId)
                .IsRequired();

            //One(vehicle) to Many(Maintinance)
            builder.HasMany(x => x.Trips)
                .WithOne(x => x.Vehicle)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.VehicleId)
                .IsRequired();

            //Index
            builder.HasIndex(x => x.Model);
            builder.HasIndex(x => x.CategoryId);




            //Constrains            
            builder.Property(x => x.LicensePlate).HasMaxLength(8).IsRequired();
            builder.Property(x => x.VehicleNo).HasDefaultValueSql("NEXT VALUE FOR VehicleSequence");

            builder.Property(x => x.Year).HasMaxLength(4).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");


        }

    }

}
