using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_RoliTheCoder2
{
    class RoliTheCoder2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"^(?<id>[0-9]+)\s*((?<eventName>#[a-zA-Z0-9]+)+)\s*(?:(?<participants>[@a-zA-Z0-9'\-\s]+))*$");

            var idEventDict = new Dictionary<int, string>();
            var eventParticipDict = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {
                var match = pattern.Match(input);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var id = int.Parse(match.Groups["id"].Value);
                var eventName = match.Groups["eventName"].Value;
                var participantsList = match.Groups["participants"].Value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

                participantsList.RemoveAll(x => !x.StartsWith("@"));


                if (!idEventDict.ContainsKey(id))
                {
                    idEventDict[id] = eventName;
                    eventParticipDict[eventName] = new List<string>(participantsList);
                }
                else if (idEventDict[id] == eventName)
                {
                    eventParticipDict[eventName].AddRange(participantsList);
                }

                input = Console.ReadLine();
            }

            var sortedDict = new Dictionary<string, List<string>>();

            foreach (var item in eventParticipDict)
            {
                sortedDict[item.Key] = new List<string>();
                var distinctedList = eventParticipDict[item.Key].Distinct().ToList();
                sortedDict[item.Key].AddRange(distinctedList);

            }

            foreach (var item in sortedDict.OrderByDescending(a => a.Value.Count()))
            {
                var eventName = item.Key.Substring(1, item.Key.Length - 1);
                var participantsCount = item.Value.Distinct().Count();


                Console.WriteLine($"{eventName} - {participantsCount}");


                foreach (var participant in item.Value.OrderBy(a => a))
                {
                    Console.WriteLine(participant);
                }
            }

        }
    }
}