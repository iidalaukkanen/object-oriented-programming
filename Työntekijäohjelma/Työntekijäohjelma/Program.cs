using System;

namespace Työntekijäohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täsä työakit:\n" +
            "___________________________________");
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Akin ego", "päällikkö", 100500);
            employees[1] = new Employee("Aki", "tyä_ukko", 5000);
            employees[2] = new Employee("tyhäm Aki", "orja", 3);

            foreach(Employee item in employees)
            {
                Console.WriteLine($"{item.PrintEmployeeInfo()}\n" +
                    $"___________________________________");
            }

            employees[0].CompareSalary(employees[1], employees[2]);
        }
    }
}
