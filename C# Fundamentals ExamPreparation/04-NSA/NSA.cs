using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NSA
{
    class NSA
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, Dictionary<string, int>>();
            
            while (input != "quit")
            {
                var inputArr = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                string countryName = inputArr[0];
                string spyName = inputArr[1];
                int daysInService = int.Parse(inputArr[2]);

                if (!result.ContainsKey(countryName))
                {
                    result.Add(countryName, new Dictionary<string, int>());
                    result[countryName].Add(spyName, daysInService);
                }
                else
                {
                    result[countryName][spyName] = daysInService;
                }  
                input = Console.ReadLine();
            }

            foreach (var contry in result.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"Country: {contry.Key}");

                foreach (var spy in contry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
        
    }
}
