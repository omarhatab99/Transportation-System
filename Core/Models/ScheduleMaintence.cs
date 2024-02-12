using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class ScheduleMaintence:BaseModel
    {
        public int Id { get; set; }
        public int VechieId { get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;
        public DateTime MainteneceDateStart { get; set; }
        public DateTime MainteneceDateEnd { get; set; }
        public bool IsMainteneceDone { get; set; } = false;

    }
}
