using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO.DTORoom
{
    public class Room : IRoom
    {
        public int RoomNumber { get; set; }
        public string Type { get; private set; }
        private int Floor { get; set; }
        private int NumberOfBeds { get; set; }
        private double BedPrice { get; set; }
        public bool isFree { get; set; }

        public Room() { isFree = true; }

        public Room(int roomNumber, int floor, Category roomCategory)
        {
            RoomNumber = roomNumber;
            Floor = floor;
            Type = roomCategory.CategoryName;
            NumberOfBeds = roomCategory.NumberOfBeds;
            //To Be Continued
            BedPrice = 0;
            isFree = true;
        }

        public void Book()
        {
            isFree = true;
        }

        public bool IsFree()
        {
            return this.isFree;
        }

        public string GetType()
        {
            return this.Type;
        }

        public int GetRoomNumber()
        {
            return this.RoomNumber;
        }

        public int GetFloor()
        {
            return this.Floor;
        }

        public int GetNumberOfBeds()
        {
            return this.NumberOfBeds;
        }

        public double GetPrice()
        {
            return (double)NumberOfBeds * BedPrice;
        }
    }
}
