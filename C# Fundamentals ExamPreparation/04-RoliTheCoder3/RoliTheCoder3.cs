using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_RoliTheCoder3
{
    class RoliTheCoder3  //NE RABOTI!!!!!
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string, List<string>>>();
            while (true)
            {
                if (input == "Time for Code")
                {
                    break;
                }

                var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.Trim()).ToArray();

                if (inputArr.Length < 2 || inputArr[1][0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }
                string id = inputArr[0];
                string eventName = inputArr[1];

                if (!result.ContainsKey(id))
                {
                    result.Add(id, new Dictionary<string, List<string>>());
                    result[id].Add(eventName, new List<string>());
                }
                if (inputArr.Length == 2)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var participantsList = inputArr.Skip(2).Where(x => x.StartsWith("@")).ToList();
                List<string> participants = new List<string>(participantsList);
                if (result.ContainsKey(id) && result[id].ContainsKey(eventName))
                {
                    result[id][eventName].AddRange(participants);
                }
                else if(!result[id].Values.Equals(eventName))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else 
                {
                    result[id].Add(eventName, new List<string>());
                    result[id][eventName].AddRange(participants);
                }   
                input = Console.ReadLine();
            }
            //NE RABOTI!!!!!

            var sortedDict = result.OrderBy(x => x.Value.First().Key).ToDictionary(x => x.Key, x => x.Value); // тук трябва да са подредени по брой участници (бр елементи в лист)

            foreach (var item in sortedDict.Values)
            {

                Console.WriteLine($"{item.First().Key} - {item.Values.Count()}");

                foreach (var participant in item.Values.OrderByDescending(x=>x))
                {
                    
                    Console.WriteLine($"{participant}");
                }
            }

        }
    }
}
