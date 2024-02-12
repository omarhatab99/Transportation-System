using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public partial class DriversTypeConfigurations : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {

            //PK
            builder.HasKey(x => x.Id);

            //Relations 
            // 1 (driver) - M (Maintenances)             
            builder.HasMany(x => x.Maintenances)
                .WithOne(x => x.Driver)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.DriverId)
                .IsRequired();

            // 1 (driver) - M (Trips)
            builder.HasMany(x => x.Trips)
                .WithOne(x => x.Driver)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.DriverId)
                .IsRequired();


            //Index
            builder.HasIndex(x => x.Username);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.HasIndex(x => x.License).IsUnique();

            //Constrains
            builder.Property(x => x.Username).HasMaxLength(50);
            builder.Property(x => x.License).HasMaxLength(14);
            builder.Property(x => x.Salary).HasDefaultValue(10000);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

        }
    }
}
