using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit2
{
    class RageQuit2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            string[] digits = Regex.Split(input, @"\D+");
            string[] words = Regex.Split(input, @"\d+").Where(x => x != null).ToArray();

            digits = digits.Where(x => x != null && x != string.Empty).ToArray();
            words = words.Where(x => x != null && x != string.Empty).ToArray();

            var result = new StringBuilder();

            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = 0; j < int.Parse(digits[i]); j++)
                {
                    result.Append(words[i]);
                }
                
            }
            
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
