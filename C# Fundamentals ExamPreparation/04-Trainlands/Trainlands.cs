using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_Trainlands
{
    class Trainlands
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var listInput = new List<string>();


            while (input != "It's Training Men!")
            {
                listInput.Add(input);
                input = Console.ReadLine();
            }

            var patternNewInfo = new Regex(@"^(?<trainName>[^\s,:>=-]+)\s*->\s*(?<wagonName>[^\s,:>=-]+)\s*:\s*(?<wagonPower>\d+)$");
            var patternRemove = new Regex(@"^(?<trainName>[^\s,:>=-]+)\s*->\s*(?<otherTrainName>[^\s,:>=-]+)$");
            var patternCopy = new Regex(@"^(?<trainName>[^\s,:>=-]+)\s*=\s*(?<otherTrainName>[^\s,:>=-]+)$");

            var result = new Dictionary<string, Dictionary<string, long>>();

            foreach (var item in listInput)
            {
                var matchNewInfo = patternNewInfo.Match(item);
                var matchRemove = patternRemove.Match(item);
                var matchCopy = patternCopy.Match(item);

                if (matchNewInfo.Success)
                {
                    string trainName = matchNewInfo.Groups["trainName"].Value.Trim();
                    string wagonName = matchNewInfo.Groups["wagonName"].Value.Trim();
                    long wagonPower = long.Parse(matchNewInfo.Groups["wagonPower"].Value.Trim());

                    if (!result.ContainsKey(trainName))
                    {
                        result.Add(trainName, new Dictionary<string, long>());
                        result[trainName].Add(wagonName, wagonPower);
                    }
                    else if (!result[trainName].ContainsKey(wagonName))
                    {

                        result[trainName].Add(wagonName, wagonPower);
                    }

                }
                else if (matchRemove.Success)
                {
                    string trainName = matchRemove.Groups["trainName"].Value.Trim();
                    string otherTrainName = matchRemove.Groups["otherTrainName"].Value.Trim();
                    if (!result.ContainsKey(trainName))
                    {
                        result.Add(trainName, new Dictionary<string, long>());
                    }
                    foreach (var wagon in result[otherTrainName])
                    {
                        result[trainName].Add(wagon.Key, wagon.Value);
                    }

                    result.Remove(otherTrainName);
                }
                else if (matchCopy.Success)
                {
                    string trainName = matchCopy.Groups["trainName"].Value.Trim();
                    string otherTrainName = matchCopy.Groups["otherTrainName"].Value.Trim();

                    result[trainName] = new Dictionary<string, long>(result[otherTrainName]);

                }
            }
            foreach (var train in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }

        }
    }
}