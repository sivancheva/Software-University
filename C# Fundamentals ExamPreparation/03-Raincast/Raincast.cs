using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03_Raincast
{
    class Raincast
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var patternType = new Regex(@"^(Type:)\s*(?<types>(?:Normal|Warning|Danger))$");
            var patternSource = new Regex(@"^(Source:)\s*(?<source>[\w+]+)$");
            var patternForecast = new Regex(@"^(Forecast:)\s*(?<forecast>[^!.,?]+)$");

            var forecast = new List<string>();

            while (true)
            {
                if (input == "Davai Emo")
                {
                    return;
                }
                while (true)
                {
                    if (input == "Davai Emo")
                    {
                        return;
                    }
                    var matchedType = patternType.Match(input);
                    if (matchedType.Success)
                    {
                        forecast.Add(matchedType.Groups["types"].Value);
                        break;
                    }

                    input = Console.ReadLine();
                }
                input = Console.ReadLine();
                if (input == "Davai Emo")
                {
                    return;
                }
                while (true)
                {
                    var matchedSource = patternSource.Match(input);
                    if (matchedSource.Success)
                    {
                        forecast.Add(matchedSource.Groups["source"].Value);
                        break;
                    }
                    input = Console.ReadLine();
                }

                input = Console.ReadLine();
                if (input == "Davai Emo")
                {
                    return;
                }
                while (true)
                {
                    var matchedForecast = patternForecast.Match(input);

                    if (matchedForecast.Success)
                    {
                        forecast.Add(matchedForecast.Groups["forecast"].Value);
                        break;
                    }

                    input = Console.ReadLine();
                }
                if (forecast.Count == 3)
                {
                    Console.WriteLine($"({forecast[0]}) {forecast[2]} ~ {forecast[1]}");
                    forecast.Clear();
                }
                input = Console.ReadLine();
            }
        }
    }
}
