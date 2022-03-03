using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companieName = cmd[0];
                string employeeID = cmd[1];
                if (!CompanyExist(companies,companieName))
                {
                    companies.Add(companieName, new List<string>());
                }
                if (CompanyExist(companies, companieName) && !EmployeeExist(companies,companieName, employeeID))
                {
                    companies[companieName].Add(employeeID);
                }
            }
            foreach (var course in companies)
            {
                Console.WriteLine($"{course.Key}");
                Console.WriteLine($"-- {String.Join("\n-- ", course.Value)}");
            }
            static bool CompanyExist(Dictionary<string, List<string>> companies, string companieName)
            {
                if (companies.ContainsKey(companieName))
                {
                    return true;
                }
                return false;
            }
            static bool EmployeeExist(Dictionary<string, List<string>> companies, string currentCompany, string employeeID)
            {
                if (companies[currentCompany].Contains(employeeID))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
