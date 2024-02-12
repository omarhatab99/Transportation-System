using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Station:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
