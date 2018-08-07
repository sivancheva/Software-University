using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _02_SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {

            var participantsList = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            var songList = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            var result = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();
            while (input != "dawn")
            {

                var candidateToSingList = input.Split(',').Select(x => x.Trim()).ToList();
                if (candidateToSingList.Count != 3)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var participantName = candidateToSingList[0];
                var song = candidateToSingList[1];
                var award = candidateToSingList[2];

                if (!participantsList.Contains(participantName) || !songList.Contains(song))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!result.ContainsKey(participantName))
                {
                    result.Add(participantName, new List<string>());

                }
                result[participantName].Add(award);

                input = Console.ReadLine();

                Console.WriteLine();
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var pair in result
                                        .OrderByDescending(a => a.Value.Distinct().ToList().Count)
                                        .ThenBy(n => n.Key))
            {
                List<string> awards = pair.Value.Distinct().ToList();

                Console.WriteLine($"{pair.Key}: {awards.Count} awards");
                foreach (string award in awards.OrderBy(n => n))
                {
                    Console.WriteLine($"--{award}");
                }

            }
        }
    }
}