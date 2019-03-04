using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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

        public Car(double engine, string model, int doors, string type, string brand, double year, double price) :
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

        public override string ToString()
        {
            return $"Tyyppi:\t\t{type}\n" +
                $"Merkki:\t\t{brand}\n" +
                $"Vuosimalli:\t{year}\n" +
                $"Hinta:\t\t{price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                $"Moottori:\t{engine:F1}\n" +
                $"Malli:\t\t{model}\n" +
                $"Ovien määrä:\t{doors}";
        }

        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;

            if (carObj == null)
                return false;
            else
            {
                return this.model.Equals(carObj.model) && this.brand.Equals(carObj.brand)
                    && this.doors.Equals(carObj.doors) && this.engine.Equals(carObj.engine)
                    && this.price.Equals(carObj.price) && this.type.Equals(carObj.type)
                    && this.year.Equals(carObj.year);
            }
        }
    }
}
