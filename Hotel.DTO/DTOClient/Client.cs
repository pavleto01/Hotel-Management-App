using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO.DTOClient
{
    public class Client : IClient
    {
        public string ID { get; private set; }
        public string EGN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string IDCardNumber { get; set; }

        public Client()
        {
            ID = Guid.NewGuid().ToString();
        }

        public Client(string egn, string name, string address, string idcardnumber)
        {
            ID = Guid.NewGuid().ToString();
            EGN = egn;
            Name = name;
            Address = address;
            IDCardNumber = idcardnumber;
        }

        public override String ToString()
        {
            throw new NotImplementedException();
        }
    }
}
