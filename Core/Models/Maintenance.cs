using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Maintenance:BaseModel
    {
        public int Id {  get; set; }
        public int VechieId {  get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; } = null!;
        public int TripId {  get; set; }
        public virtual Trip Trip { get; set; } = null!;
        public decimal CostOfMaintenece {  get; set; }

    }
}
