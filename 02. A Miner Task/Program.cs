using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, double> mined = new Dictionary<string, double>();
            while ((input = Console.ReadLine()) != "stop")
            {
                double quantity = double.Parse(Console.ReadLine());
                if (!mined.ContainsKey(input))
                {
                    mined.Add(input, 0);
                    mined[input] += quantity;
                }
                else
                {
                    mined[input] += quantity;
                }
            }
            foreach (var item in mined)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
