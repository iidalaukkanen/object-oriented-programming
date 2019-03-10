using System;

namespace Tuoterekisteriohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filePath = @"C:\Dev\temp\items.json";
            FileManager file = new FileManager(filePath);
            file.ReadJson();

            do
            {
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(file.PrintJson());
                        Console.WriteLine("Haluatko tulostaa tuotteen kaikki tiedot? K/E");
                        input = Console.ReadKey();
                        if (input.Key == ConsoleKey.K)
                        {
                            Console.Clear();
                            Console.WriteLine(file.PrintJson());
                            file.FindItem(IdInput());
                        }
                        else
                            Console.Clear();
                        break;

                    case ConsoleKey.D2:
                        file.PrintByGroup(GroupName());
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        file.PrintZeroStock();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("1. Lisää kommentti\n" +
                            "2. Poista kommentti");
                        input = Console.ReadKey();
                        if(input.Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            file.AddComment(IdInput());
                        }
                        
                        else if (input.Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            file.DeleteComment(IdInput());
                        }

                        else
                            Console.WriteLine("Väärä syöte! Palataan alkuun.");
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Väärä valinta!!!");
                        break;
                }
                file.UpdateFile();
                Console.WriteLine("Paina nappulaa jatkaaksesi...");
                Console.ReadKey();
                Console.Clear();

            }
            while (true);
        }

        static int IdInput()
        {
            Console.Write("Syötä tuotteen id: ");
            int input;
            while(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Väärä syöte! Syötä numero.");
            }
            return input;
        }

        static ConsoleKeyInfo Group()
        {
            Console.Clear();
            Console.WriteLine("1. Lajittelu ja säilytys\n" +
                "2. Paperit ja lehtiöt\n" +
                "3. Kynät\n" +
                "4. Kortit ja kirjekuoret");
            return Console.ReadKey();
        }

        static string GroupName()
        {
            string s = string.Empty;
            switch (Group().Key)
            {
                case ConsoleKey.D1:
                    s = "Lajittelu ja säilytys";
                    break;

                case ConsoleKey.D2:
                    s = "Paperit ja lehtiöt";
                    break;

                case ConsoleKey.D3:
                    s = "Kynät";
                    break;

                case ConsoleKey.D4:
                    s = "Kortit ja kirjekuoret";
                    break;

                default:
                    break;
            }
            Console.Clear();
            return s;
        }

        static void Intro()
        {
            Console.WriteLine("TUOTEREKISTERIOHJELMA\n" +
                "1. Tulosta kaikki tuotteet.\n" +
                "2. Tulosta tuotteet ryhmän mukaan.\n" +
                "3. Tulosta loppuunmyydyt tuotteet.\n" +
                "4. Lisää tai poista kommentti.\n" +
                "X. Poistu ohjelmasta.");
        }
    }
}
