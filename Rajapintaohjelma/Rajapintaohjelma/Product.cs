using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Rajapintaohjelma
{
    interface IProduct
    {
        Product GetProduct(string name);
        string CalculateTotal();
    }

    class Product : IProduct
    {
        public string name;
        public double price;
        public int amount;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public Product GetProduct(string name)
        {
            if (this.name == name)
                return this;
            else
                return null;
        }

        public string CalculateTotal()
        {
            return (price * Convert.ToDouble(amount)).ToString("c", CultureInfo.CurrentCulture);
        }

        public override string ToString()
        {
            return $"Nimi: {name}\tHinta: {price:F2}€\t Määrä: {amount}";
        }
    }
}
