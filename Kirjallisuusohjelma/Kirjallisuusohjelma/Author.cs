using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjallisuusohjelma
{
    class Author
    {
        public string name;
        public string birthday;
        public Book _book;

        public Author()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public void PrintAuthor()
        {
            Console.WriteLine($"Kirjailija:\t{this.Name}\n" +
                $"Syntymäpäivä:\t{this.Birthday}");
            this.Book.PrintBook();
        }
    }
}
