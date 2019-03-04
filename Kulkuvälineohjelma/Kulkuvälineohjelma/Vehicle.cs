using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Kulkuvälineohjelma
{
    abstract class Vehicle
    {
        protected string type;
        protected string brand;
        protected double year;
        protected double price;

        public Vehicle()
        {
        }

        public Vehicle(string type, string brand, double year, double price)
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
                $"Hinta:\t\t{this.price.ToString("c", CultureInfo.CurrentCulture)}\n");
        }
    }
}
