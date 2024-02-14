using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Core.ViewModels
{
    public class TripVm
    {
        public int Id { get; set; }
        public int TripNo { get; set; }
        public DateTime DepatureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Source { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public long VehicleNo { get; set; }
        public int VehicleId { get; set; }
        public string Vehicle { get; set; } = null!;
        public int DriverId { get; set; }
        public string Driver { get; set; } = null!;
        public int Reservation { get; set; }
        public int AvailabelSeats { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime TimeForStart { get; set; }
        public decimal Fare { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool Done { get; set; } = false;
    }
}
