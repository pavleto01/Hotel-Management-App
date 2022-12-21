using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO.DTORoom
{
    public class Category : ICategory
    {
        public string CategoryName { get; set; }
        public int NumberOfBeds { get; set; }

        public Category() { }
        public Category(string categoryName, int numberOfBeds)
        {
            CategoryName = categoryName;
            NumberOfBeds = numberOfBeds;
        }
    }
}
