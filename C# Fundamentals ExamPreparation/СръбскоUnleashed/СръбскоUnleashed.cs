using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21_10_SrubskoUnleashed
{
    class SrubskoUnleashed
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"^(?<singer>[A-Za-z\s]+)\s{1}@(?<venue>[A-Za-z\s]+)\s{1}(?<price>[\d]+)\s{1}(?<ticketCount>[\d]+)$");
            
            var result = new Dictionary<string, Dictionary<string, long>>();
            while (input != "End")
            {
                var match = pattern.Match(input);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var singer = match.Groups["singer"].Value;
                var venue = match.Groups["venue"].Value;
                int price = int.Parse(match.Groups["price"].Value);
                long ticketCount = int.Parse(match.Groups["ticketCount"].Value);
                long profit = (long)price * ticketCount;

                if (!result.ContainsKey(venue))
                {
                    result.Add(venue, new Dictionary<string, long>());
                    result[venue].Add(singer, profit);
                }
                else if (!result[venue].ContainsKey(singer))
                {
                    result[venue][singer] = profit;
                }
                else
                {
                    result[venue][singer] += profit;
                }

                input = Console.ReadLine();

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var singer in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }

            }
        }
    }
}
