using System;
using System.Collections.Generic;

namespace Kulkuvälineohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car(1,"Aki", 7, "kiituri", "Tiainen", 1996, 100500),
                new Car(2, "Auto", 5, "henkilöauto", "Autonen", 2000, 2000),
                new Truck(3, "iso", 3, "pyllerö", "aksu", 1996, 123456789, 83, 10)
            };

            while(true)
            {
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        foreach(var item in vehicles)
                        {
                            item.PrintInfo();
                            Console.WriteLine("_________________________________\n");
                        }
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        if (vehicles[0].Equals(vehicles[1]))
                            Console.WriteLine("Listan ensimmäinen auto on sama kuin toinen auto.");
                        else
                            Console.WriteLine("Listan ensimmäinen auto on eri kuin toinen auto.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Truck truck = (Truck)vehicles[2];
                        truck.CalculateConsumption();
                        Console.WriteLine("__________________________________\n");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }

                Console.Clear();
            }
        }

        static void Intro()
        {
            Console.WriteLine("AJONEUVO-OHJELMA:\n" +
                "1. Tulosta lista ajoneuvoista.\n" +
                "2. Vertaile listan ajoneuvoja.\n" +
                "3. Laske rekka-tyypin ajoneuvojen kulutus.\n" +
                "X. Poistu ohjelmasta.");
            
        }
    }
}
