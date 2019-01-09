using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjaohjelma
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public decimal price;

        public Book(string title, string author, string id, decimal price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public string PrintInfo()
        {
            return $"Nimi: {this.title}\n" +
                   $"Kirjoittaja: {this.author}\n" +
                   $"Id: {this.id}\n" +
                   $"Hinta: {this.price}\n";
            
        }

        public string CompareBook(Book book)
        {
            string text = "";
            
            if (this.price > book.price)
            {
                text = $"{this.title} on kalliimpi kuin {book.title}.";
            }
            else if (book.price > this.price)
            {
                text = $"{book.title} on kalliimpi kuin {this.title}.";
            }
            else
            {
                text = $"{this.title} ja {book.title} ovat saman hintaisia.";
            }

            return text;
        }
    }
}
