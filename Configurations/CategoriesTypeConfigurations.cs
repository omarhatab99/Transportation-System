using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Configurations
{
    public class CategoriesTypeConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            //Primary Key
            builder.HasKey(x => x.Id);

            //Relations 

            // 1 (Category) - M (Vehicles)
            builder.HasMany(x => x.Vehicles)
                .WithOne(x => x.Category)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();



            //Index
            builder.HasIndex(x => x.Name).IsUnique();



            //Constrains
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");


        }
    }
}

