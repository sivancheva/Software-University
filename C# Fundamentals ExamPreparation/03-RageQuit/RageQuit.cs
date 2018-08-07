using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var digits = Regex.Matches(input, @"\d+").Cast<Match>().Select(x => int.Parse(x.ToString())).ToList();
            var letters = Regex.Split(input.ToUpper(), @"\d+").ToArray();
            letters = letters.Take(letters.Count() - 1).ToArray();

            string temp;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < letters.Length; i++)
            {
                temp = new StringBuilder().Insert(0, letters[i], digits[i]).ToString();
                result.Append(temp);
            }

            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);

            //
        }
    }
}



