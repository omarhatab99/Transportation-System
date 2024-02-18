using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;

namespace TransportReservationSystem.Core.Constants
{
    public class Validation
    {
        public static ValidationResult DriverValidation(DriverVm driver)
        {
            ValidationResult validationResult = new ValidationResult();

            bool IsValidPhone(string phone)
            {
                string pattern = @"^(\+201|01|00201)[0-2,5]{1}[0-9]{8}";

                return Regex.IsMatch(phone, pattern);
            }

            bool IsValidEmail(string email)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }

            // Method to validate password using regular expression
            bool IsValidPassword(string password)
            {
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
                return Regex.IsMatch(password, pattern);
            }


            if (string.IsNullOrEmpty(driver.Username))
            {
                validationResult.MessageError = "Username must be required ..!!";
                validationResult.IsValid = false;
            }
            else if(string.IsNullOrEmpty(driver.Email))
            {
                validationResult.MessageError = "Email must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidEmail(driver.Email))
            {
                validationResult.MessageError = "Please enter a valid email address ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(driver.Password))
            {
                validationResult.MessageError = "Password must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidPassword(driver.Password))
            {
                validationResult.MessageError = "Please enter a valid password (at least 8 characters)";
                // ", containing at least one uppercase letter, one lowercase letter, one digit, and one special character ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(driver.Phone))
            {
                validationResult.MessageError = "Phone must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidPhone(driver.Phone))
            {
                validationResult.MessageError = "Please enter a valid phone number ..!!";
                validationResult.IsValid = false;
            }
            else if (driver.Salary <= 0 )
            {
                validationResult.MessageError = "Please enter a valid Salary ..!!";
                validationResult.IsValid = false;
            }
            else if (driver.License <= 0)
            {
                validationResult.MessageError = "Please enter a valid Licence ..!!";
                validationResult.IsValid = false;
            }
            else if (Convert.ToString(driver.License)?.Length != 14)
            {
                validationResult.MessageError = "Please enter a valid Licence ..!!";
                validationResult.IsValid = false;
            }
            else
            {
                validationResult.IsValid = true;

            }

            return validationResult;

        }

        public static ValidationResult VehicleValidation(VehicleVm vehicle)
        {
            ValidationResult validationResult = new ValidationResult();

            if (vehicle.CategoryId <= 0)
            {
                validationResult.MessageError = "Category must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(vehicle.Model))
            {
                validationResult.MessageError = "Model must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(vehicle.Brand))
            {
                validationResult.MessageError = "Brand must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(vehicle.Color))
            {
                validationResult.MessageError = "Color must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (vehicle.Year <= 0)
            {
                validationResult.MessageError = "Please enter a valid Year ..!!";
                validationResult.IsValid = false;
            }
            else if (vehicle.LicensePlate <= 0)
            {
                validationResult.MessageError = "Please enter a valid License Plate ..!!";
                validationResult.IsValid = false;
            }
            else if (Convert.ToString(vehicle.LicensePlate)?.Length != 8)
            {
                validationResult.MessageError = "Please enter a valid License Plate ..!!";
                validationResult.IsValid = false;
            }
            else
            {
                validationResult.IsValid = true;

            }

            return validationResult;

        }

        public static ValidationResult PassengerValidation(PassengerVm passenger)
        {
            ValidationResult validationResult = new ValidationResult();

            bool IsValidPhone(string phone)
            {
                string pattern = @"^(\+201|01|00201)[0-2,5]{1}[0-9]{8}";


                return Regex.IsMatch(phone, pattern);
            }

            bool IsValidEmail(string email)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }

            // Method to validate password using regular expression
            bool IsValidPassword(string password)
            {
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
                return Regex.IsMatch(password, pattern);
            }

            if (string.IsNullOrEmpty(passenger.Username))
            {
                validationResult.MessageError = "Username must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(passenger.Email))
            {
                validationResult.MessageError = "Email must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidEmail(passenger.Email))
            {
                validationResult.MessageError = "Please enter a valid email address ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(passenger.Password))
            {
                validationResult.MessageError = "Password must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidPassword(passenger.Password))
            {
                validationResult.MessageError = "Please enter a valid password (at least 8 characters)";
                // ", containing at least one uppercase letter, one lowercase letter, one digit, and one special character ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(passenger.Phone))
            {
                validationResult.MessageError = "Phone must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidPhone(passenger.Phone))
            {
                validationResult.MessageError = "Please enter a valid phone number ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(passenger.Gender))
            {
                validationResult.MessageError = "Gender must be required ..!!";
                validationResult.IsValid = false;
            }
            else
            {
                validationResult.IsValid = true;

            }
            return validationResult;
        }

        public static ValidationResult TripValidation(TripVm trip)
        {
            ValidationResult validationResult = new ValidationResult();

            if (string.IsNullOrEmpty(trip.Source))
            {
                validationResult.MessageError = "Source must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(trip.Destination))
            {
                validationResult.MessageError = "Destination must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (trip.Source.ToLower() == trip.Destination.ToLower())
            {
                validationResult.MessageError = "Source station is the same of Destination station ..!!";
                validationResult.IsValid = false;
            }
            else if (trip.Fare <= 0)
            {
                validationResult.MessageError = "Please enter a valid Fare ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(trip.DepatureDate.ToString()))
            {
                validationResult.MessageError = "Depature Date must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (trip.DepatureDate < DateTime.Now)
            {
                validationResult.MessageError = "Depature Date must be in the future ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(trip.ArrivalDate.ToString()))
            {
                validationResult.MessageError = "Arrival Date must be required ..!!";
                // ", containing at least one uppercase letter, one lowercase letter, one digit, and one special character ..!!";
                validationResult.IsValid = false;
            }

            else if (trip.ArrivalDate <= trip.DepatureDate)
            {
                validationResult.MessageError = "Arrival Date must be more than Depature Date ..!!";
                validationResult.IsValid = false;
            }
            else
            {
                validationResult.IsValid = true;

            }
            return validationResult;
        }
    }
}
