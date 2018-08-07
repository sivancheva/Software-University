using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var ticketsList = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();


            for (int i = 0; i < ticketsList.Count; i++)
            {
                var currentTicket = ticketsList[i];

                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                else if (currentTicket.Length == 20)
                {
                    if (currentTicket.All(x => x.Equals(currentTicket[0])))
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10{currentTicket[0]} Jackpot!");
                        continue;
                    }
                    
                    var leftPart = currentTicket.Substring(0, 10);
                    var rightPart = currentTicket.Substring(10, 10);

                    var pattern = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");
                    var matchLeft = pattern.Match(leftPart);
                    var matchRight = pattern.Match(rightPart);

                    if (!matchLeft.Success || !matchRight.Success)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\"- no match");
                        continue;
                    }

                    var leftMostOcuurencedChar = matchLeft.Value;                    
                    var rightMostOcuurencedChar = matchRight.Value;


                    if (leftMostOcuurencedChar[0] != rightMostOcuurencedChar[0])
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                        continue;
                    }
                    else if (leftMostOcuurencedChar[0] == rightMostOcuurencedChar[0])
                    {
                        int symbolCount = Math.Min(leftMostOcuurencedChar.Length, rightMostOcuurencedChar.Length);
                        Console.WriteLine($"ticket \"{currentTicket}\" - {symbolCount}{rightMostOcuurencedChar[0]}");
                    }

                }
            }
        }
    }
}