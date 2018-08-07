using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUniKaraoke2
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.Trim()).ToArray();
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.Trim()).ToArray();


            var result = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (true)
            {
                if (input == "dawn")
                {
                    break;
                }
                var inputArr = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => x.Trim()).ToArray();
                              
                if (inputArr.Length != 3 || !participants.Contains(inputArr[0]) || !songs.Contains(inputArr[1]))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string participant = inputArr[0];
                string award = inputArr[2];
                if (!result.ContainsKey(participant))
                {
                    result.Add(participant, new List<string>());
                    result[participant].Add(award);
                }
                else if(result[participant].Contains(award))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    result[participant].Add(award);
                }
                
                input = Console.ReadLine();
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            foreach (var participant in result.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                foreach (var award in participant.Value.OrderBy(x=>x))
                {
                  Console.WriteLine($"--{award}");                                        
                }

            }
        }
    }
}
