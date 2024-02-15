using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Core.ViewModels
{
    public class ReservationVm
    {
        public int Id { get; set; }
        public int TripNo {  get; set; }
        public int PassengerId { get; set; }
        public int ReservationId { get; set; }

        public Passenger Passenger { get; set; } = null!;
        public  string PassengerName { get; set; } = null!;
        public  int NumberOfSeats { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; } = null!;
        public List<string> Seats { get; set; } = new List<string>();
        public decimal TotalCost { get; set; }
        public bool Status { get; set; } = true;
    }
}
