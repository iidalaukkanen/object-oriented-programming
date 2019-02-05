using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lipunhinta
{
    class Ticket
    {
        public double price = 16;
        public double discount = 0;

        public Ticket()
        {

        }

        public void Calculator(Person person)
        {
            if (person.conscript)
                discount = 0.5;

            else if (person.student)
            {
                if (person.mtk)
                    discount = 0.6;
                else
                    discount = 0.45;
            }

            else
            {
                if (person.Age < 7 && person.Age > 0)
                    discount = 1;

                else if (person.Age > 0 && (person.Age < 15 || person.Age > 65))
                    discount = 0.5;

                else if (person.mtk)
                    discount = 0.15;
            }

            this.price = this.price - this.price * this.discount;
        }

        public void PrintTicketPrice()
        {
            Console.Clear();
            Console.WriteLine($"Lippusi hinta on {price.ToString("c", CultureInfo.CurrentCulture)}");
        }
    }
}
