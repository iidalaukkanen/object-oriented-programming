using System;

namespace Auto_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.AskData();

            Car newCar = new Car();
            newCar.AskData();

            car.ShowInfo();
            Console.WriteLine("\n_______________________\n");
            newCar.ShowInfo();
            Console.WriteLine("\n_______________________\n");
        }
    }
}
