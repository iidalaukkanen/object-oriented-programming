using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Firmaohjelma
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public int income;
        public int expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.income = 0;
            this.expense = 0;
        }

        public Company(string title, string address, string phone, int income, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expense = expense;
        }

        public Company(Company previousCompany)
        {
            title = previousCompany.title;
            address = previousCompany.address;
            phone = previousCompany.phone;
            income = previousCompany.income;
            expense = previousCompany.expense;
        }

        public string Profit()
        {
            string s = string.Empty;
            decimal profit = (this.income - this.expense) / this.expense;

            if (profit < 1)
                s = "Voi Jeesus yritä edes...";

            else if (profit <= 2)
                s = "Nyt vähän tsemppiä!";

            else if (profit <= 3)
                s = "Jatka samaa rataa.";

            else
                s = "Hienosti menee!";

            return $"Voittoprosentti: {profit.ToString("p")}. {s}";
        }

        public override string ToString()
        {
            return "Firma:\t" + this.title + "\nOsoite:\t" + this.address + "\nPuh.:\t" + this.phone + "\nTulot:\t" + this.income.ToString("c", CultureInfo.CurrentCulture) + "\nMenot:\t" + this.expense.ToString("c");

        }
    }
}
