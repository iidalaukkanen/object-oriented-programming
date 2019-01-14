using System;
using System.Collections.Generic;
using System.Text;

namespace Firmaohjelma
{
    class Company
    {
        public string title;
        public string address;
        public int phone;
        public int outcome;
        public int expense;

        public Company()
        {
            this.title = "";
            this.address = "";
            this.phone = 0;
            this.outcome = 0;
            this.expense = 0;
        }

        public Company(string title, string address, int phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
    }
}
