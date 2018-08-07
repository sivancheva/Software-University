using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_RageQuit2
{
    class RageQuit2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var digits = Regex.Split(input, @"\D+").ToList();
            digits.RemoveAll(x => x == "");
            var strings = Regex.Split(input, @"\d+").ToList();
            strings.RemoveAll(x => x == "");

            var sb = new StringBuilder();

            for (int i = 0; i < digits.Count; i++)
            {
                var stringToAppend = string.Concat(Enumerable.Repeat(strings[i], int.Parse(digits[i])));
                sb.Append(stringToAppend.ToUpper());
            }
            
            int uniqueElements = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueElements}");
            Console.WriteLine(sb);
        }
    }
}
