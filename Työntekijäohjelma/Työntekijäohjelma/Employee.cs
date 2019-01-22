using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Työntekijäohjelma
{
    class Employee
    {
        public string name;
        public int id;
        public string position;
        public double salary;
        private static int counter = 1;

        public Employee(string name, string position, double salary)
        {
            this.name = name;
            this.id = counter++;
            this.position = position;
            this.salary = salary;
        }

        public string PrintEmployeeInfo()
        {
            return $"Työntekijä:\t {this.name} \nId:\t\t {this.id} \nTehtävä:\t {this.position} \nPalkka:\t\t {this.salary}";
        }

        public void CompareSalary(Employee x, Employee y)
        {
            if(this.salary > x.salary)
              Console.WriteLine($"{this.name}n palkka {this.salary} on suurempi kuin {x.name}n palkka {x.salary}.");
            else if(x.salary > this.salary)
                Console.WriteLine($"{x.name}n palkka {x.salary} on suurempi kuin {this.name}n palkka {this.salary}.");
            else
                Console.WriteLine($"{x.name}n ja {this.name}n palkat ovat yhtä suuria.");

            if (this.salary > y.salary)
                Console.WriteLine($"{this.name}n palkka {this.salary} on suurempi kuin {y.name}n palkka {y.salary}.");
            else if (y.salary > this.salary)
                Console.WriteLine($"{y.name}n palkka {y.salary} on suurempi kuin {this.name}n palkka {this.salary}.");
            else
                Console.WriteLine($"{y.name}n ja {this.name}n palkat ovat yhtä suuria.");

            if (y.salary > x.salary)
                Console.WriteLine($"{y.name}n palkka {y.salary} on suurempi kuin {x.name}n palkka {x.salary}.");
            else if (x.salary > y.salary)
                Console.WriteLine($"{x.name}n palkka {x.salary} on suurempi kuin {y.name}n palkka {y.salary}.");
            else
                Console.WriteLine($"{x.name}n ja {y.name}n palkat ovat yhtä suuria.");
        }
    }
}
