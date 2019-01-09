using System;

namespace Kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjat: ");
            Book newBook = new Book("Aapinen", "Mikael Agricola", "00001", 100500.50M);
            Console.WriteLine(newBook.PrintInfo());

            Book newBook2 = new Book("Peppi Pitkätossu", "Astrid Lindgren", "00002", 18.95M);
            Console.WriteLine(newBook2.PrintInfo());

            Console.WriteLine(newBook.CompareBook(newBook2)); 
        }      
    }
}
