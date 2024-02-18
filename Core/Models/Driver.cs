using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Driver:User
    {
        public int Id {  get; set; }
        public long License { get; set; }
        public string Phone { get; set; } = null!;
        public bool HasBouns { get; set; } = false;
        public decimal Bouns { get; set; }
        public int WorkedTrip { get; set; }
        public decimal Salary {  get; set; }
        public string? CurrentStation { get; set; } = "FREE";
        public bool IsAvailable { get; set; } = true;
        public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
        public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();
    }
}
