using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Models
{
    public class Category:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Capacity {  get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
