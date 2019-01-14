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
            Console.WriteLine("Anna luku, jolla auton nopeutta lisätään:  ");
            car.Accelerate(Console.ReadLine());
            car.Brake();



            Console.WriteLine("\n_______________________\n");
        }
    }
}
