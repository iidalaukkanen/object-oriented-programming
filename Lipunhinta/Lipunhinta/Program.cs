using System;

namespace Lipunhinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee maatalousnäyttelyn lipun hinnan. Syötä pyydetyt tiedot.");
            Person newPerson = CreatePerson();
            Ticket ticket = CreateTicket(newPerson);
            PrintInfo(newPerson, ticket);
        }

        static Person CreatePerson()
        {
            int age;
            Person firstPerson = new Person();
            firstPerson.AskConscript();
            if (firstPerson.conscript == false)
            {
                firstPerson.AskStudent();
                firstPerson.AskMTK();
                if (firstPerson.student == false)
                {
                    do
                    {
                        Console.WriteLine("Syötä ikäsi: ");
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine($"ei ole numero!! sos");
                        }

                        if (age < 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä syöte! Ikä ei voi olla negis.");
                        }
                    }
                    while (age < 1);
                    firstPerson.Age = age;
                }
            }
            return firstPerson;
        }

        static Ticket CreateTicket(Person x)
        {
            Ticket ticket = new Ticket();
            ticket.Calculator(x);
            return ticket;
        }

        static void PrintInfo(Person x, Ticket y)
        {
            x.Print();
            y.PrintTicketPrice();
        }
    }
}
