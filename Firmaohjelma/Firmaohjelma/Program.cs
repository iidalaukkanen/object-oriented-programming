using System;

namespace Firmaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("FIRMAN TIEDOT");
            Console.WriteLine("________________________");
            Company company = new Company("Akin virma",
                                          "Päälliköntie 1",
                                          "0503395919",
                                           1000500,
                                           100500);

            Company enterprise = new Company(company);
            Console.WriteLine(company.ToString());
            Console.WriteLine(company.Profit());
        }
    }
}
