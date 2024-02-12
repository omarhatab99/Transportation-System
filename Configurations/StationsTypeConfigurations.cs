using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class StationsTypeConfigurations : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {

            //PK
            builder.HasKey(x => x.Id);

            //Relations 
            // one (trip) to many (staions)



            //Index
            builder.HasIndex(x => x.Name).IsUnique();



            //Constrains
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(t => t.CreatedAt).HasDefaultValueSql("GETDATE()");

        }
    }

}
