using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_WormIpsum
{
    class WormIpsum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = (@"^([A-Z]{1})([^\.]*)\.$");

            while (input != "Worm Ipsum")
            {
                
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }
                var inputArr = input.Split(new[] { ' ','.' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                
                foreach (var word in inputArr)
                {
                    var mostRepeatedLetter = word.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                    int ocurrences = word.Count(c => c == mostRepeatedLetter);
                    if (ocurrences >= 2)
                    {
                        string wordToReplace = new string(mostRepeatedLetter, word.Length);
                        var index = Array.FindIndex(inputArr, x => x == word);
                        inputArr[index] = wordToReplace;
                    }
                }
                Console.WriteLine(String.Join(" ",inputArr)+ ".");
                input = Console.ReadLine();
            }
        }
    }
}
