using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Configurations;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Data.Context
{
    public class ApplicaitonDbContext:DbContext
    {
        public ApplicaitonDbContext()
        {
                
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer( "Data Source=.; Initial Catalog = Transport; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasSequence<int>("TripSequence").StartsAt(100000000)
                .IncrementsBy(1);

            modelBuilder.HasSequence<int>("VehicleSequence").StartsAt(100000000)
                .IncrementsBy(1);

            //Configurations
            new CategoriesTypeConfigurations().Configure(modelBuilder.Entity<Category>());
            new DriversTypeConfigurations().Configure(modelBuilder.Entity<Driver>());
            new MaintenancesTypeConfigurations().Configure(modelBuilder.Entity<Maintenance>());
            new PassengersTypeConfigurations().Configure(modelBuilder.Entity<Passenger>());
            new ReservationsTypeConfigurations().Configure(modelBuilder.Entity<Reservation>());
            new ScheduleMaintencesTypeConfigurations().Configure(modelBuilder.Entity<ScheduleMaintence>());
            new StaffTypeConfigurations().Configure(modelBuilder.Entity<Staff>());
            new StationsTypeConfigurations().Configure(modelBuilder.Entity<Station>());
            new TripsTypeConfigurations().Configure(modelBuilder.Entity<Trip>());
            new VehiclesTypeConfigurations().Configure(modelBuilder.Entity<Vehicle>());


            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(x => x.GetForeignKeys()).Where(x => x.DeleteBehavior == DeleteBehavior.Cascade && !x.IsOwnership);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }


        //DB Sets
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<ScheduleMaintence> ScheduleMaintences { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
