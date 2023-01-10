using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Candidate
{
    internal class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }

        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }

        public Adress(string city, string street, int houseNumber, int flatNumber)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }
    }
}


