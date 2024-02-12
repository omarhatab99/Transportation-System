using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Constants
{
    public class ValidationResult
    {
        public bool IsValid {  get; set; } = false;
        public string MessageError {  get; set; } = string.Empty;

    }
}
