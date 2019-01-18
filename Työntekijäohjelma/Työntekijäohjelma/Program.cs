using System;

namespace Työntekijäohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täsä röi_akit:\n" +
            "___________________________________");
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("akin ego", 1, "päällikkö", "100500 luonnossa");
            employees[1] = new Employee("aki", 2, "röi_ukko", "kalia");
            employees[2] = new Employee("tyhäm aki", 3, "tossutettava", "kolome markkaa");

            foreach(Employee item in employees)
            {
                Console.WriteLine($"{item.PrintEmployeeInfo()}\n" +
                    $"___________________________________");
            }
        }
    }
}
