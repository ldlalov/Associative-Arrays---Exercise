using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> input = Console.ReadLine().Split(' ').ToList();
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<string,int> myDictionary = new Dictionary<string,int>();
            foreach (char item in input)
            {
                if (item != 32)
                {
                    if (myDictionary.ContainsKey(item.ToString()))
                    {
                        myDictionary[item.ToString()]++;
                    }
                    else
                    {
                        myDictionary.Add(item.ToString(), 1);

                    }
                }
            }
            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
