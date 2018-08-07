using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WormsWorldParty2
{
    class WormsWorldParty2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string, long>>();


            while (true)
            {
                if (input == "quit")
                {
                    break;
                }

                var inputArr = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                string wormName = inputArr[0];
                string teamName = inputArr[1];
                long score = long.Parse(inputArr[2]);

                if (result.Values.Any(x => x.ContainsKey(wormName)))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!result.ContainsKey(teamName))
                {
                    result.Add(teamName, new Dictionary<string, long>());
                    result[teamName].Add(wormName, score);
                }
                else if(!result[teamName].ContainsKey(wormName))
                {
                    result[teamName].Add(wormName, score);
                }

                input = Console.ReadLine();
            }

            int counter = 1;
            foreach (var team in result
                                .OrderByDescending( x=>x.Value.Sum(y => y.Value))
                                .ThenByDescending(x => x.Value.Average(y => y.Value)))
              
            {
                
                Console.WriteLine($"{counter}. Team: {team.Key} - {team.Value.Sum(x => x.Value)}");
                counter++;

                foreach (var worm in team.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}
