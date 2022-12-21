using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DTO.DTORegistration;

namespace HotelProject.Hotel.Factories
{
    public class RegistrationFactory
    {
        public static IRegistration MakeRegistration(string RegisterNumber, DateTime DateOfRegistry, Guid ClientID, int RoomNumber, DateTime StartDate, DateTime EndDate, double TotalPrice)
        {
            return new Registration(RegisterNumber, DateOfRegistry, ClientID, RoomNumber, StartDate, EndDate, TotalPrice);
        }
    }
}
