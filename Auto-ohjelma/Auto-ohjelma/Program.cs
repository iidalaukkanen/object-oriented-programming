using System;

namespace Auto_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.AskData();
            car.ShowInfo();
            car.Brake();



            Console.WriteLine("\n_______________________\n");
        }
    }
}
