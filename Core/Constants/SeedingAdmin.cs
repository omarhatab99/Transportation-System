using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Data.Context;

namespace TransportReservationSystem.Core.Constants
{
    public class SeedingAdmin
    {
        private static ApplicaitonDbContext context = new ApplicaitonDbContext();

        public static void SeedingAdminWithLoginFormStart()
        {
            //admin
            string username = "admin";
            string email = "admin@gmail.com";
            string password = "admin123456";
            string role = Role.ADMIN.ToString();

            //Get All Staff

            List<Staff> staff = context.Staff.Where(x => !x.IsDeleted).ToList();

            if (staff.Any()) //staff has any object.
            {

                Staff isExisted = staff.FirstOrDefault(x => x.Email.ToLowerInvariant() == email.ToLowerInvariant());
                if (isExisted == null) //admin not found.
                {
                    Staff admin = new Staff()
                    {
                        Username = username,
                        Email = email,
                        Password = password,
                        Role = role
                    };

                    context.Staff.Add(admin);
                    context.SaveChanges();
                }

            }
            else
            {
                Staff admin = new Staff()
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    Role = role
                };

                context.Staff.Add(admin);
                context.SaveChanges();
               

            }


        }

    }
}
