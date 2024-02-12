using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Passenger:User
    {
        public int Id { get; set; }
        public string Phone {  get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        
    }
}
