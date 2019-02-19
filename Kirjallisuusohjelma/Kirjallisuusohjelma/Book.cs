using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Kirjallisuusohjelma
{
    class Book
    {
        public string title;
        public string author;
        public string publisher;
        public double _price;
        public static string genreName;

        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this._price = 0;
        }

        public Book(string title, string author, string publisher, double price, string genre)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this._price = price;
            genreName = genre;
        }

        public void BookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {this.title}\n" +
                              $"Kirjailija: {this.author}" +
                              $"Julkaisija: {this.publisher}\n" +
                              $"Genre: {genreName}\n" +
                              $"Hinta: {this._price:N2}€");
        }

        public void FindBook(string name)
        {
            if (name == this.title)
            {
                Console.WriteLine($"{name} löydetty!");
                Console.WriteLine($"Kirjan nimi: {this.title}\n" +
                                  $"Kirjailija: {this.author}\n" +
                                  $"Julkaisija: {this.publisher}\n" +
                                  $"Genre: {genreName}\n" +
                                  $"Hinta: {this._price:N2} €.\n" +
                                  $"___________________________\n");
            }
            

            else
                Console.WriteLine($"Kirjaa {name} ei löytynyt.");
        }
    
        public static void ChangeGenre()
        {
            Console.Write("Syötä uusi genre:");
            genreName = Console.ReadLine();
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 30)
                    _price = value * 0.9;
                else
                    _price = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }

        public void PrintBook()
        {
            Console.WriteLine($"Kirja:\t\t{title}\n" +
                $"Julkaisija:\t{publisher}\n" +
                $"Hinta:\t\t{_price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                $"Genre:\t\t{genreName}\n" +
                $"___________________________________\n");
        }
    }
}
