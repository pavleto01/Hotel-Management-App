using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DTO.DTORoom;

namespace HotelProject.Hotel.Factories
{
    public static class RoomFactory
    {
        public static IRoom CreateRoom(int roomNumber, int floor, Category roomCategory)
        {
            return new Room(roomNumber, floor, roomCategory);
        }

        public static Category CreateCategory(RoomType type)
        {
            int numberOfBeds = 0;
            switch (type)
            {
                case RoomType.Apartament: numberOfBeds = 4; break;
                case RoomType.Single: numberOfBeds = 1; break;
                case RoomType.Double: numberOfBeds = 2; break;
                case RoomType.Triple: numberOfBeds = 3; break;
                default: break;
            }

            return new Category(type.ToString(), numberOfBeds);
        }
    }
}
