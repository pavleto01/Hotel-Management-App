using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO.DTORoom
{
    public interface IRoom
    {
        bool IsFree();
        string GetType();
        int GetFloor();
        int GetRoomNumber();
        int GetNumberOfBeds();
        double GetPrice();
    }
}
