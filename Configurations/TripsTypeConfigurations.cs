using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class TripsTypeConfigurations : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {

            //PK
            builder.HasKey(x => x.Id);


            //Relations 

            // 1 (vehicle) - M (Trip) --> Done in the Vehicle Configrations  
            // 1 (trip) - M (Reservations)             
            builder.HasMany(x => x.Reservations)
                .WithOne(x => x.Trip)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.TripId)
                .IsRequired();


            //Index
            builder.HasIndex(x => new { x.VehicleId, x.DepatureDate }).IsUnique();
            builder.HasIndex(x => new { x.DriverId , x.DepatureDate}).IsUnique();
            builder.HasIndex(x => x.DepatureDate);
            builder.HasIndex(x => x.Source);
            builder.HasIndex(x => x.Destination);
            builder.HasIndex(x => x.DriverId);
            builder.HasIndex(x => x.VehicleId);


            //Constrains
            builder.Property(x => x.TripNo).HasDefaultValueSql("NEXT VALUE FOR TripSequence");
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            //The Other constraints Implemnted in the Trip Model 



        }
    }
}
