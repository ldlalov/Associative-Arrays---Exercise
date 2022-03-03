using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items.Add("shards", 0);
            items.Add("motes", 0);
            items.Add("fragments", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool quantityReached = false;
            while (quantityReached == false)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string matherial = input[i + 1].ToLower();
                    switch (matherial)
                    {
                        case "shards":
                            AddItem(items, matherial, quantity);
                            break;
                        case "fragments":
                            AddItem(items, matherial, quantity);
                            break;
                        case "motes":
                            AddItem(items, matherial, quantity);
                            break;
                        default:
                            AddJunk(junk, matherial, quantity);
                            break;
                    }
                    foreach (var item in items)
                    {
                        if (item.Value >= 250)
                        {
                            switch (item.Key)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }
                            quantityReached = true;
                            break;
                        }
                    }
                    if (quantityReached)
                    {
                        break;
                    }
                }
            }
            foreach (var item in items)
            {
                if (item.Value < 250)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                else
                {
                    Console.WriteLine($"{item.Key}: {item.Value - 250}");
                }
            }
                foreach (var item in junk)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
        static void AddItem(Dictionary<string, int> items, string matherial, int quantity)
            {
                items[matherial] += quantity;
            }
        static void AddJunk(Dictionary<string, int> junk, string matherial, int quantity)
            {
                if (junk.ContainsKey(matherial))
                {
                    junk[matherial] += quantity;
                }
                else
                {
                    junk.Add(matherial, quantity);
                }
            }
        }
    }
}
