using System;
using System.Collections.Generic;
using System.Text;

namespace Kulkuvälineohjelma
{
    class Car : Vehicle
    {
        protected double engine;
        protected string model;
        protected int doors;

        public Car()
        {
        }

        public Car(double engine, string model, int doors, string type, string brand, int year, int price):
            base(type, brand, year, price)
        {
            this.engine = engine;
            this.model = model;
            this.doors = doors;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Moottori:\t{this.engine}\n" +
                $"Malli:\t\t{this.model}\n" +
                $"Ovia:\t\t{this.doors}\n");
        }
    }
}
