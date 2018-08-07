using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_RainAir
{
    class RainAir
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, List<int>>();

            while (true)
            {
                if (input == "I believe I can fly!")
                {
                    break;
                }

                if (!input.Contains("="))
                {
                    var customerFlights = input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    var customerName = customerFlights[0];
                    var flights = new List<int>(customerFlights.Skip(1).Select(int.Parse)).ToList();

                    if (!result.ContainsKey(customerName))
                    {
                        result.Add(customerName, new List<int>());                        
                    }
                    result[customerName].AddRange(flights);
                }
                else
                {
                    var customers = input.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    var firstCustomer = customers[0];
                    var secondCustomer = customers[1];

                    result[firstCustomer] = new List<int>(result[secondCustomer]);
                }
                input = Console.ReadLine();
               
            }
            foreach (var customer in result.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{customer.Key} ::: {String.Join(", ", customer.Value.OrderBy(x=>x)) }");
            }
        }
    }
}
