using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class ReservationsTypeConfigurations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {

            //PK
            builder.HasKey(x => x.Id);

            //Relations 

            // 1 (Passengers) - M (Reservation) --> Done in the Passengers  Configurations
            // 1 (Trips) - M (Reservation) --> Done in the Trips  Configurations


            //Index
            builder.HasIndex(x => new {x.TripId , x.PassengerId}).IsUnique();

            //Constrains
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

        }

    }

}
