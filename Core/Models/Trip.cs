using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Trip:BaseModel
    {
        public int Id {  get; set; }
        public int TripNo {  get; set; }
        public DateTime DepatureDate {  get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Source { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; } = null!;
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public decimal Fare { get; set; }
        public int AvailableSeats { get; set; }
        public bool Done { get; set; } = false;
        public int HomeAndAway {  get; set; }


    }
}
