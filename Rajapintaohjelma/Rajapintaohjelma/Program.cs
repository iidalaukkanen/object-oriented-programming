using System;
using System.Globalization;
using System.Collections.Generic;

namespace Rajapintaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> productList = new List<Product>()
            {
                new Product("karkkikeppi", 4, 1234),
                new Product("tikkukaramelli", 2, 3000),
                new Product("suklaatipatukka", 1, 999)
            };

            List<Customer> customerList = new List<Customer>()
            {
                new Customer("Aki", 200),
                new Customer("Iida", 8),
                new Customer("Pate", 3000)
            };

            Store store = new Store("Iitan namupuoti", 100500);

            foreach (var item in productList)
            {
                store.AddProduct(item);
            }

            foreach (var item in customerList)
            {
                store.AddCustomer(item);
            }

            while (true)
            {
                Console.Clear();
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        foreach (var item in productList)
                        {
                            Console.WriteLine(item.GetProduct(item.name));
                           
                        }
                        Console.WriteLine("Paina nappulaa jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        foreach (var item in customerList)
                        {
                            Console.WriteLine($"{item.GetCustomer(item.name)} \tBonus: {item.GetBonus()}");
                          
                        }
                        Console.WriteLine("Paina nappulaa jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine(store.ToString());
                        Console.WriteLine("Paina nappulaa jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void Intro()
        {
            Console.WriteLine("TERVETULOA IITAN NAMUPUOTIIN!\n" +
                "1. Tulosta tuotetiedot.\n" +
                "2. Tulosta asiakkaiden tiedot.\n" +
                "3. Tulosta kaupan tiedot.\n" +
                "X. Poistu ohjelmasta.");
        }
    }
}
