using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DTO.DTORoom;
using Hotel.DTO.DTOClient;
using Hotel.DTO.DTORegistration;
using HotelProject.Hotel.Inquiry;

namespace HotelProject.Hotel
{
    class Hotel
    {
        List<IRoom> rooms {get; set;}
        List<IClient> clients {get; set;}
        List<IRegistration> registrations { get; set; }
        string name { get; set; }

        public Hotel()
        {
            rooms = new List<IRoom>();
            clients = new List<IClient>();
            registrations = new List<IRegistration>();
        }

        public Hotel(List<IRoom> rooms, List<IClient> clients, List<IRegistration> registrations, string name)
        {
            this.rooms = rooms;
            this.clients = clients;
            this.registrations = registrations;
            this.name = name;
        }

        public void addRoom(IRoom room)
        {
            this.rooms.Add(room);
        }

        public void addClient(IClient client)
        {
            this.clients.Add(client);
        }

        public void addRegistration(IRegistration registration)
        {
            this.registrations.Add(registration);
        }

        public List<IRoom> getFreeRooms()
        {
            return this.rooms.Where(x => x.IsFree() == true).OrderBy(x => x.GetType()).ToList();
        }

        public String GenerateFreeRoomsInquiry()
        {
            var inquiry = new HotelProject.Hotel.Inquiry.Inquiry();
            return inquiry.GenerateFreeRoomInquiry(getFreeRooms(), this.name);
        }

        public String GenerateRevenueInquiry(RevenueDuration duration)
        {
            var inquiry = new HotelProject.Hotel.Inquiry.Inquiry();
            return inquiry.GenerateRevenueInquiry(registrations, duration, this.name);
        }

        public String GenerateClientInfoInquiry()
        {
            var inquiry = new HotelProject.Hotel.Inquiry.Inquiry();
            return inquiry.GenerateClientInfoInquiry(registrations, clients, this.name);
        }

    }
}
