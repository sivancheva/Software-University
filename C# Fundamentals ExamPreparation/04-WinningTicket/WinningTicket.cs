using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _04_WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();


            for (int i = 0; i < input.Length; i++)
            {

                if (input[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                else if (input[i].Length == 20)
                {
                    Regex r = new Regex($@"^[$]{{{20}}}|[@]{{{20}}}|[#]{{{20}}}|[\^]{{{20}}}$");
                    bool containsAny = r.IsMatch(input[i]);
                    if (containsAny)
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - 10{input[i][0]} Jackpot!");
                        continue;
                    }

                    string firstHalf = input[i].Substring(0, 10);
                    string secondHalf = input[i].Substring(10, 10);

                    //Regex r2 = new Regex($@"^[$]{{{6,10}}}|[@]{{{6,10}}}|[#]{{{6,10}}}|[\^]{{{6,10}}}$"); //gre6en RegEx
                    Regex r2 = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");  //pravilen Regex

                    bool firstHalfMatch = r2.IsMatch(firstHalf);
                    bool secondfMatch = r2.IsMatch(secondHalf);


                    if (!firstHalfMatch || !secondfMatch)
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                        continue;
                    }
                    var firstHalfMatchString = r2.Match(firstHalf).ToString(); //
                    var secondHalfMatchString = r2.Match(secondHalf).ToString(); //


                    if (firstHalfMatchString[0] != secondHalfMatchString[0])
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                        continue;
                    }
                    else if (firstHalfMatchString[0] == secondHalfMatchString[0])
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - {Math.Min(firstHalfMatchString.Length, secondHalfMatchString.Length)}{firstHalfMatchString[0]}");
                        continue;
                    }
                }
            }
        }
    }
}
