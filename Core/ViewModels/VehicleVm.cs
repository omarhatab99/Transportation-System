using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Core.ViewModels
{
    public class VehicleVm
    {
        public int? Id { get; set; }
        public long? LicensePlate { get; set; }
        public string? Model { get; set; } = null!;
        public string? Brand { get; set; } = null!;
        public int? Year { get; set; }
        public string? Color { get; set; } = null!;
        public int? VehicleNo { get; set; }
        public bool IsAvailable { get; set; } = true;
        public bool HasMaintenance { get; set; } = false;
        public int? CategoryId { get; set; }
        public string? Category { get; set; } = null!;
        public int? ScheduleMaintences { get; set; }
        public int? Maintenances { get; set; }
        public int? Trips { get; set; }
        public bool HasScheduledMaintenance { get; set; } = false;
        public string? CurrentStation { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
