using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada2
{
    class HornetArmada2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var legionActivity = new Dictionary<string, int>();
            var legionSoldierCount = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { "=","->",":" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

                var lastActivity = int.Parse(input[0]);
                var legionName = input[1];
                var soldierType = input[2];
                var soldierCount = long.Parse(input[3]);


                if (!legionActivity.ContainsKey(legionName) || 
                    ((legionActivity.ContainsKey(legionName) && legionActivity[legionName] < lastActivity)))
                {
                    legionActivity[legionName] = lastActivity;
                }

                if (!legionSoldierCount.ContainsKey(legionName))
                {
                    legionSoldierCount.Add(legionName, new Dictionary<string, long>());
                    legionSoldierCount[legionName].Add(soldierType, soldierCount);
                }
                else if (!legionSoldierCount[legionName].ContainsKey(soldierType))
                {
                    legionSoldierCount[legionName].Add(soldierType, soldierCount);
                }
                else if (legionSoldierCount[legionName].ContainsKey(soldierType))
                {
                    legionSoldierCount[legionName][soldierType] += soldierCount;
                }
                
            }

            var command = Console.ReadLine();

            if (command.Contains("\\"))
            {
                var commandArr = command.Split('\\').ToArray();
                var searchedLastActivity = int.Parse(commandArr[0]);
                var searchedSoldierType = commandArr[1];

                foreach (var legion in legionSoldierCount
                                            .Where(x => x.Value.ContainsKey(searchedSoldierType))
                                            .OrderByDescending(x => x.Value[searchedSoldierType]))
                {

                    if (legionActivity[legion.Key] < searchedLastActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionSoldierCount[legion.Key][searchedSoldierType]}");

                    }
                }

            }
            else
            {

            }

        }
    }

    
}
