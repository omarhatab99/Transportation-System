using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public class StaffTypeConfigurations : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {

            //Primary Key
            builder.HasKey(x => x.Id);

            //Relations 


            //Index
            builder.HasIndex(x => x.Username).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();


            //Constrains
            builder.Property(x => x.Username).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");


        }

    }
}

