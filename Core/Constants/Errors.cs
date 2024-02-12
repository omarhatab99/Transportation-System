using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportReservationSystem.Core.Constants
{
    public class Errors
    {
        public static string PasswordInvalid { get; set; } = "Password must at least 8 character and numbers ..!!";
        public static string EmailRequiredMSG { get; set; } = "Email Fiel Must Be Required..!!";
        public static string PasswordRequiredMSG { get; set; } = "Password Fiel Must Be Required..!!";
    }
}
