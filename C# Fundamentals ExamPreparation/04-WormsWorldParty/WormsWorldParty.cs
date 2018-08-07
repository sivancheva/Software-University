using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WormsWorldParty
{
    class WormsWorldParty
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var result = new Dictionary<string, List<WormNameScore>>();


            while (true)
            {
                if (input == "quit")
                {
                    break;
                }

                var inputArr = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                string wormName = inputArr[0];
                string teamName = inputArr[1];

                if (result.Values.Any(x => x.Any(y=>y.WarmName == wormName)))
                {
                    input = Console.ReadLine();
                    continue;
                }

                WormNameScore tempWormNameScore = new WormNameScore();
                tempWormNameScore.WarmName = wormName;
                tempWormNameScore.Score = long.Parse(inputArr[2]);                              

                if (!result.ContainsKey(teamName))
                {
                    result.Add(teamName, new List<WormNameScore>());
                    result[teamName].Add(tempWormNameScore);
                }
                else if (result[teamName].All(x => x.WarmName != wormName))
                {
                    result[teamName].Add(tempWormNameScore);
                }
                input = Console.ReadLine();
            }

            int counter = 1;
            foreach (var team in result
                                .OrderByDescending(x=>x.Value.Sum(y=>y.Score))
                                .ThenByDescending(x=>x.Value.Average(y=>y.Score)))
            {

                Console.WriteLine($"{counter}. Team: {team.Key} - {team.Value.Sum(x => x.Score)}");
                counter++;

                foreach (var worm in team.Value.OrderByDescending(x=>x.Score))
                {
                    Console.WriteLine($"###{worm.WarmName} : {worm.Score}");
                }
            }

        }
        class WormNameScore
        {
            public string WarmName { get; set; }
            public long Score { get; set; }
        }
    }
    
}
