using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DTO.DTOClient;

namespace HotelProject.Hotel.Factories
{
    public static class ClientFactory
    {
        public static IClient CreateClient(string egn, string name, string address, string idcardnumber)
        {
            return new Client(egn, name, address, idcardnumber);
        }
    }
}
