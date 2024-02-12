using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem
{
    public class Repository
    {

        public static List<User>  users = new List<User>()
        {
            new User(){Email = "Omarhatab@gmail.com" , Username = "Omar hatab" , Password = "123456"},
            new User(){Email = "Mohamedhatab@gmail.com" , Username = "Mohamed hatab" , Password = "12345"},
            new User(){Email = "Mostafahatab@gmail.com" , Username = "Mostafa hatab" , Password = "1234"},
            new User(){Email = "Bakrhatab@gmail.com" , Username = "Bakr hatab" , Password = "123"},
            new User(){Email = "Hazemhatab@gmail.com" , Username = "Hazem hatab" , Password = "12"},
        };


        public static List<User> LoadUsers()
        {
            return users;
        }

    }
}
