using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Core.ViewModels
{
    public class DriverVm
    {
        public int? Id { get; set; }
        public long? License {  get; set; }
        public string? Username { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? Password { get; set; }
        public decimal? Salary { get; set; }
        public bool? HasBouns { get; set; }
        public string? CurrentStation { get; set; }
        public int? Trips { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int? Maintenances { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
