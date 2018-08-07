using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var eventsDict = new Dictionary<int, string>();
            var resultDict = new Dictionary<string, List<string>>();
            var patterParticipantName = new Regex(@"^@[a-zA-Z\d+'-]+$");

            while (input != "Time for Code")
            {
                var inputArray = input.Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim()).ToArray();

                if (inputArray.Length < 2)
                {
                    input = Console.ReadLine();
                    continue;
                }
                int eventId = 0;
                try
                {
                    eventId = int.Parse(inputArray[0]);
                }
                catch
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (inputArray[1][0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }
                string eventName = inputArray[1].Substring(1, inputArray[1].Length - 1);

                var participantsList = new List<string>();


                for (int i = 2; i < inputArray.Length; i++)
                {
                    var matchedParticipantName = patterParticipantName.Match(inputArray[i]);
                    if (matchedParticipantName.Success)
                    {
                        participantsList.Add(inputArray[i]);
                    }

                }
                if (!eventsDict.ContainsKey(eventId))
                {
                    eventsDict[eventId] = eventName;

                    resultDict.Add(eventName, new List<string>());

                    for (int i = 0; i < participantsList.Count; i++)
                    {
                        resultDict[eventName].Add(participantsList[i]);
                    }
                }
                else if (eventsDict.ContainsKey(eventId) && eventsDict[eventId] == eventName)
                {
                    for (int i = 0; i < participantsList.Count; i++)
                    {
                        resultDict[eventName].Add(participantsList[i]);
                    }
                }


                input = Console.ReadLine();
            }


            var sortedDict = resultDict
                                    .OrderByDescending(a => a.Value.Distinct().Count())
                                    .ThenBy(a => a.Value)
                                    .ToList();

            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Distinct().Count()}");

                foreach (var participant in item.Value.Distinct().OrderBy(a => a))
                {
                    Console.WriteLine($"{participant}");
                }

            }

        }
    }
}