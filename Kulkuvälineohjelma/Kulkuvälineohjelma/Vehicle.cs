using System;
using System.Collections.Generic;
using System.Text;

namespace Kulkuvälineohjelma
{
    class Vehicle
    {
        protected string type;
        protected string brand;
        protected double year;
        protected double price;

        public Vehicle()
        {
            type = null;
            brand = null;
            year = 0;
            price = 0.00;
        }

        public Vehicle(string type, string brand, int year, int price)
        {
            this.type = type;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Tyyppi:\t\t{this.type}\n" +
                $"Merkki:\t\t{this.brand}\n" +
                $"Vuosimalli:\t{this.year}\n" +
                $"Hinta:\t\t{this.price}\n");
        }
    }
}
