using System;

namespace Kirjallisuusohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book firstBook = new Book("Akin paras kirja", "Aki", "Akin kirjamesta", 33.33, "tositarina");
            Book secondBook = new Book("Iidan elämäkerta", "Aki", "Akin kirjamesta", 69.69, "elämäkerta");

            while (true)
            {
                Intro();

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        firstBook.FindBook(firstBook.title);
                        secondBook.FindBook(secondBook.title);
                        Console.WriteLine("Paina nappulaa palataksesi valikkoon.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Book.ChangeGenre();
                        Console.WriteLine("Paina näppäintä vaihtaaksesti genreä.");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        firstBook.Price = firstBook._price;
                        secondBook.Price = secondBook._price;
                        Console.WriteLine("Kirjojen hintoja on alennettu!");
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
            Console.WriteLine("1. Tulosta kirjalista.\n"+
                "2. Vaihda kirjojen genret.\n"+
                "3. Laske kirjoille alennus.\n"+
                
                "X. Poistu ohjelmasta.");
        }
    }
}
