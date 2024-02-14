using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Vehicle:BaseModel
    {
        public int Id { get; set; }
        public long LicensePlate { get; set; }
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public int Year {  get; set; }
        public string Color { get; set; } = null!;
        public int VehicleNo { get; set; }
        public bool IsAvailable { get; set; } = true;
        public bool HasMaintenance { get; set; } = false;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<ScheduleMaintence> ScheduleMaintences { get; set; } = new List<ScheduleMaintence>();
        public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();
        public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
        public bool HasScheduledMaintenance { get; set; } = false;
        public string? CurrentStation { get; set; } = "FREE";


    }
}
