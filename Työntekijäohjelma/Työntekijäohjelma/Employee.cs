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
        public string salary;
        private static int counter = 0;

        public Employee(string name, int id, string position, string salary)
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

        public void CompareSalary()
        {

        }
    }
}
