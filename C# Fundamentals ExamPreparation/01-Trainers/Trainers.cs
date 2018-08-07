using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Trainers
{
    class Trainers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            result.Add("Technical", 0m);
            result.Add("Theoretical", 0m);
            result.Add("Practical", 0m);

            for (int i = 0; i < n; i++)
            {
                long distance = long.Parse(Console.ReadLine()) * (long)1600; // in meter
                decimal cargo = decimal.Parse(Console.ReadLine()) * 1000m; // in kg
                string team = Console.ReadLine();


                decimal income = 1.5m * cargo - (decimal)distance * 0.7m * 2.5m;

                if (result.ContainsKey(team))
                {
                    result[team] += income;
                }
            }

            foreach (var item in result.OrderByDescending(x => x.Value).Take(1))
            {
                Console.WriteLine($"The {item.Key} Trainers win with ${item.Value:f3}.");
            }
        }
    }
}