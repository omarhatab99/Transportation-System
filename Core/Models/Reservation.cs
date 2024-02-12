using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Reservation:BaseModel
    {
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; } = null!;
        public int TripId { get; set; }
        public virtual Trip Trip { get; set; } = null!;
        public List<string> Seats { get; set; } = new List<string>();
        public decimal TotalCost {  get; set; }
        public bool Status { get; set; } = true;

    }
}
