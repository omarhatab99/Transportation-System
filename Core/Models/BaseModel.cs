using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Constants;

namespace TransportReservationSystem.Core.Models
{
    public class BaseModel
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set;}
        public bool IsDeleted { get; set; } = false;

    }
}
