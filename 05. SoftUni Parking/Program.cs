using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cars = new Dictionary<string, string>();
            int guests = int.Parse(Console.ReadLine());
            for (int i = 0; i < guests; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "register":
                        string cmd = command[0];
                        string username = command[1];
                        string licensePlateNumber = command[2];
                        if (!ErrorPlate(cars, username, licensePlateNumber))
                        {
                            cars.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        break;
                    case "unregister":
                        cmd = command[0];
                        username = command[1];
                        if (!cars.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            cars.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
            static bool ErrorPlate(Dictionary<string, string> cars, string username, string licensePlateNumber)
            {
                foreach (var item in cars)
                {
                    if (item.Key == username)
                    {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                            return true;
                    }
                }
                return false;
            }
        }
    }
}
