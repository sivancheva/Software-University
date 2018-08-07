using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PhoenixOscarRomeoNovember
{
    class PhoenixOscarRomeoNovember
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var result = new Dictionary<string, List<string>>();


            while (input != "Blaze it!")
            {
                var inputArr = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                if (inputArr.Length != 2)
                {
                    input = Console.ReadLine();
                }
                string creature = inputArr[0];
                string squadMate = inputArr[1];

                if (!result.ContainsKey(creature))
                {
                    result.Add(creature, new List<string>());
                    result[creature].Add(squadMate);
                }
                else if (!result[creature].Contains(squadMate))
                {
                    result[creature].Add(squadMate);
                }

                input = Console.ReadLine();
            }

            var modifiedResultDict = new Dictionary<string, List<string>>();

            foreach (var pair in result)
            {
                modifiedResultDict.Add(pair.Key, new List<string>());
                modifiedResultDict[pair.Key].AddRange(pair.Value);
            }

            foreach (var creature in result)
            {
                var nameCreature = creature.Key;

                foreach (var squardMate in creature.Value.ToList())
                {
                    if (result.Keys.Any(x => x.Equals(squardMate)) && result[squardMate].Contains(nameCreature))
                    {
                        modifiedResultDict[nameCreature].Remove(squardMate);
                    }
                }
            }

            foreach (var a in modifiedResultDict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{a.Key} : {a.Value.Count}");
            }


        }
    }
}