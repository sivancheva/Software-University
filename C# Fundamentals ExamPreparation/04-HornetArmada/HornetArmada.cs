using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _04_HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var legionNameActivity = new Dictionary<string, int>();
            var legionNameSolder = new Dictionary<string, Dictionary<string, long>>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputArr = input.Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();


                var lastActivity = int.Parse(inputArr[0]);
                var legionName = inputArr[1];
                var soldierType = inputArr[2];
                var soldierCount = long.Parse(inputArr[3]);


                if (!legionNameActivity.ContainsKey(legionName))
                {
                    legionNameActivity.Add(legionName, lastActivity);
                }
                if (legionNameActivity[legionName] < lastActivity)
                {
                    legionNameActivity[legionName] = lastActivity;
                }


                if (!legionNameSolder.ContainsKey(legionName))
                {
                    legionNameSolder.Add(legionName, new Dictionary<string, long>());
                    legionNameSolder[legionName].Add(soldierType, soldierCount);
                }
                else if (!legionNameSolder[legionName].ContainsKey(soldierType))
                {
                    legionNameSolder[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    legionNameSolder[legionName][soldierType] += soldierCount;
                }

            }
            var command = Console.ReadLine();
            var patternCommand = new Regex(@"^(?<num>[\d]+)\\(?<soldier>[a-zA-Z]+)$");
            var matchedCommand = patternCommand.Match(command);

            if (matchedCommand.Success)
            {
                int num = int.Parse(matchedCommand.Groups["num"].Value);
                string soldier = matchedCommand.Groups["soldier"].Value;

                foreach (var legion in legionNameSolder
                                        .Where(x => x.Value.ContainsKey(soldier))
                                        .OrderByDescending(x => x.Value[soldier]))
                {

                    if (legionNameActivity[legion.Key] <= num)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionNameSolder[legion.Key][soldier]}");
                    }
                }
            }
            else
            {
                foreach (var legion in legionNameActivity.OrderByDescending(x => x.Value))
                {
                    if (legionNameSolder[legion.Key].ContainsKey(command))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }

    }
}