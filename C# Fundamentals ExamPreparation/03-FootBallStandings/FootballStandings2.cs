
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
namespace _03_FootballStandings2
{
    class FootballStandings2
    {
        static void Main(string[] args)
        {
            var key = Regex.Escape(Console.ReadLine());

            var patern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]*)(?:{key}).* (?<goalsTeam1>\d+):(?<goalsTeam2>\d+).*$";

            var matchRegex = new Regex(patern);
            var chart = new Dictionary<string, Score>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "final")
                {
                    break;
                }

                var match = matchRegex.Match(line); // tuk matchvame celija teks ot inputa, a ne samo otdelnite elementi , kakto bi bilo s Matches
                var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var team1Goals = int.Parse(match.Groups["goalsTeam1"].Value);
                var team2Goals = int.Parse(match.Groups["goalsTeam2"].Value);

                if (!chart.ContainsKey(team1Name))
                {
                    chart.Add(team1Name, new Score());

                }

                if (!chart.ContainsKey(team2Name))
                {
                    chart.Add(team2Name, new Score());

                }

                chart[team1Name].Goals += team1Goals;
                chart[team2Name].Goals += team2Goals;

                if (team1Goals > team2Goals)
                {
                    chart[team1Name].Points += 3;

                }

                else if (team1Goals < team2Goals)
                {
                    chart[team2Name].Points += 3;
                }
                else
                {
                    chart[team1Name].Points += 1;
                    chart[team2Name].Points += 1;
                }


            }
            var leagueStandings = chart
                                    .OrderByDescending(a => a.Value.Points)
                                    .ThenBy(a => a.Key)
                                    .ToArray();

            Console.WriteLine("League standings:");


            for (int i = 0; i < leagueStandings.Length; i++)
            {
                var place = i + 1;
                var currentStandigs = leagueStandings[i];
                var country =currentStandigs.Key;
                var points = currentStandigs.Value.Points;

                Console.WriteLine($"{place}. {country} {points}");
            }
            Console.WriteLine("Top 3 scored goals:");

            var leagueStandings2 = chart
                                    .OrderByDescending(a => a.Value.Goals)
                                    .ThenBy(a => a.Key)
                                    .Take(3)
                                    .ToArray();
                                    

            foreach (var item in leagueStandings2)
               
            {
                Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
              
            }
        }
        class Score
        {
            public decimal Points { get; set; }
            public decimal Goals { get; set; }
        }

    }
}