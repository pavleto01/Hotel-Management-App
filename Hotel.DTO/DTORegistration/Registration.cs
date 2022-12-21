using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO.DTORegistration
{
    public class Registration : IRegistration
    {
        public string RegisterNumber { get; private set; }
        public DateTime DateOfRegistry { get; set; }
        public string ClientID { get; set; }
        public int RoomNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPrice { get; set; }

        public Registration(string RegisterNumber, DateTime DateOfRegistry, Guid ClientID, int RoomNumber, DateTime StartDate, DateTime EndDate, double TotalPrice)
        {
            this.RegisterNumber = RegisterNumber;
            this.DateOfRegistry = DateOfRegistry;
            this.ClientID = ClientID.ToString();
            this.RoomNumber = RoomNumber;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TotalPrice = TotalPrice;
        }

    }
}
