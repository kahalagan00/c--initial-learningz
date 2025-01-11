using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class RealEstate
    {
        // Fields 
        private string _address;

        // Constructor
        public RealEstate(string address) {
            _address =  address;
            Console.WriteLine("I RUN FIRST");
        }

        // Properties
        public string Address { 
            get => _address; 
            set => _address = value; 
        }
        public int Price { get; set; }
        public int SquareFootage { get; set; }
        public int CalculatePricePerSquareFoot() => Price / SquareFootage;
    }
}