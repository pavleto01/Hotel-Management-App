using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DTO.DTORoom;
using Hotel.DTO.DTORegistration;
using Hotel.DTO.DTOClient;
using System.Collections;

namespace HotelProject.Hotel.Inquiry
{
    public class Inquiry
    {
        public string GenerateFreeRoomInquiry(List<IRoom> rooms, string hotelName)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Hotel '").Append(hotelName).AppendLine("'");
            sb.Append("Date: ").AppendLine(DateTime.Now.ToString());
            sb.AppendLine();
            sb.AppendLine("Free Rooms:");

            foreach (var room in rooms)
            {
                sb.Append("Room type: ").AppendLine(room.GetType());
                sb.Append("Room number: ").AppendLine(room.GetRoomNumber().ToString());
                sb.Append("Room floor: ").AppendLine(room.GetFloor().ToString());
                sb.Append("Room price: ").AppendLine(room.GetPrice().ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string GenerateRevenueInquiry(List<IRegistration> regs, RevenueDuration duration, string hotelName)
        {
            var registrations = regs.Cast<Registration>().ToList(); 

            double sum = 0;

            StringBuilder sb = new StringBuilder();

            sb.Append("Hotel '").Append(hotelName).AppendLine("'");
            sb.Append("Date: ").AppendLine(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Revenue from the reservations made in the last ");
            switch (duration)
            {
                case RevenueDuration.OneDay: {sb.AppendLine("one day:");sum = registrations
                                            .Where(s => s.StartDate >= DateTime.Today.AddDays(-1))
                                            .Sum(s => s.TotalPrice);} break;
                case RevenueDuration.OneMonth: {sb.AppendLine("one month:");sum = registrations
                                            .Where(s => s.StartDate >= DateTime.Today.AddMonths(-1))
                                            .Sum(s => s.TotalPrice);} break;
                case RevenueDuration.LastTreeMonths:{ sb.AppendLine("tree months:");sum = registrations
                                            .Where(s => s.StartDate >= DateTime.Today.AddMonths(-3))
                                            .Sum(s => s.TotalPrice);} break;
                case RevenueDuration.LastSixMonths:{ sb.AppendLine("six months:");sum = registrations
                                            .Where(s => s.StartDate >= DateTime.Today.AddMonths(-6))
                                            .Sum(s => s.TotalPrice);} break;
                case RevenueDuration.LastYear:{ sb.AppendLine("year:"); sum = registrations
                                            .Where(s => s.StartDate >= DateTime.Today.AddYears(-1))
                                            .Sum(s => s.TotalPrice);} break;
                default: break;
            }

            sb.Append("Generated revenue: ").AppendLine(sum.ToString());

            return sb.ToString();
        }

        public string GenerateClientInfoInquiry(List<IRegistration> regs, List<IClient> cl, string hotelName)
        {
            var registrations = regs.Cast<Registration>().ToList();
            var clients = cl.Cast<Client>().ToList(); 

            StringBuilder sb = new StringBuilder();
            sb.Append("Hotel '").Append(hotelName).AppendLine("'");
            sb.Append("Date: ").AppendLine(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Clients from the last year");


            List<string> clientsID = registrations.Where(s => s.StartDate >= DateTime.Today.AddYears(-1)).Select(s => s.ClientID).ToList<string>();

            List<Client> clientsInfo = clients.Where(s => clientsID.Contains(s.ID)).ToList();

            foreach (var ci in clientsInfo)
            {
                sb.Append(ci.Name).Append(" ").AppendLine(ci.EGN);
            }

            return sb.ToString();

        }
    }
}
