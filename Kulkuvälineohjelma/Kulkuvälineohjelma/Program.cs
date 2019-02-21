using System;

namespace Kulkuvälineohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1234567890,"Aki", 7, "kiituri", "Tiainen", 1996, 7);
            car.PrintInfo();
            Console.WriteLine("________________________");

            

        }
    }
}
