using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;

namespace TransportReservationSystem.Core.Constants
{
    public class Constants
    {

        public Constants()
        {
            
        }

        public static ValidationResult AuthenticationValidation(string email , string password)
        {
            ValidationResult validationResult = new ValidationResult();

            if (string.IsNullOrEmpty(email))
            {
                validationResult.MessageError = Errors.EmailRequiredMSG; 
                return validationResult;
            }
            else if(string.IsNullOrEmpty(password))
            {
                validationResult.MessageError = Errors.PasswordRequiredMSG;
                return validationResult;
            }
            else
            {
                //Check User By Email And Password.
                User user = Repository.LoadUsers().Where(x => x.Email == email && x.Password == password).FirstOrDefault();
                bool isAuthentication = (user != null) ? true : false;

                if(isAuthentication)
                {
                    validationResult.IsValid = isAuthentication;
                    return validationResult;
                }
                else
                {
                    validationResult.IsValid = isAuthentication;
                    validationResult.MessageError = "Email Or Password May Be Incorrect..!!";
                    return validationResult;
                }

            }
        }




    }

    public enum Role
    {
        DRIVER = 1,
        PASSENGER = 2,
        ADMIN = 3,
        STAFF = 4
    }

    public enum Reservation
    {
        ONGOING = 1,
        CANCELATION = 2,

    }
}
