using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products1 = new Dictionary<string, double>(); 
            Dictionary<string, double> products = new Dictionary<string, double>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmd = input.Split(' ');
                string name = cmd[0];
                double price = double.Parse(cmd[1]);
                double quantity = double.Parse(cmd[2]);
                if (products1.ContainsKey(name))
                {
                    products1[name] = price;
                }
                else
                {
                    products1.Add(name, price);
                }
                if (products.ContainsKey(name))
                {
                    products[name] += quantity;
                }
                else
                {
                    products.Add(name, quantity);
                }
            }
            foreach (var item in products)
            {
                double total = products1.First(x => x.Key == item.Key).Value*item.Value;
            Console.WriteLine($"{item.Key} -> {total:f2}");
            }
        }
    }
}
