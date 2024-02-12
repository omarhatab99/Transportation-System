using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class PassengersTypeConfigurations : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {

            //PK
            builder.HasKey(x => x.Id);

            //Relations 

            //Basic many-to-many
            // M (Reservation) - M (Passengers)   --> Done in the Reservations Configurations        
            builder.HasMany(x => x.Reservations)
                    .WithOne(x => x.Passenger)
                    .HasPrincipalKey(x => x.Id)
                    .HasForeignKey(x => x.PassengerId)
                    .IsRequired();


            //Index
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Gender);



            //Constrains
            builder.Property(x => x.Username).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(350);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
        }

    }
}
