﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Rajapintaohjelma
{
    interface IProducts
    {
        void AddProduct(Product product);
        void PrintProducts();
    }

    interface ICustomers
    {
        void AddCustomer(Customer customer);
        void PrintCustomers();
    }

    class Store : IProducts, ICustomers
    {
        public string name;
        public double revenue;

        public List<Product> productList = new List<Product>();
        public List<Customer> customerList = new List<Customer>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteet: {productList.Count}");
            foreach (var p in productList)
            {
                Console.WriteLine($"Tuote: {p.name}\tMäärä: {p.amount}\tHinta: {p.price.ToString("c", CultureInfo.CurrentCulture)}\tTotal: {p.CalculateTotal()}");
            }
            Console.WriteLine("_________________________\n");
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"Asiakkaat: {customerList.Count}");
            foreach (var c in customerList)
            {
                Console.WriteLine($"{c.ToString()}\tBonus:{c.GetBonus()}");
            }
            Console.WriteLine("_________________________\n");
        }

        public override string ToString()
        {
            return $"Kaupan nimi: {name}\n" +
                $"Liikevaihto: {revenue.ToString("c", CultureInfo.CurrentCulture)}\n" +
                $"Asiakkaat: {customerList.Count}\n" +
                $"Tuotteet: {productList.Count}";
        }
    }

    
}

   

