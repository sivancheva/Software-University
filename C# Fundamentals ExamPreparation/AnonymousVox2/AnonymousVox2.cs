using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox2
{
    class AnonymousVox2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var placeholders = Console.ReadLine().Split(new char[] { '{', '}'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var pattern = new Regex(@"([a-zA-Z]+)(?<placeholder>.*)\1");

            var matches = pattern.Matches(input).Cast<Match>().ToList();

            for (int i = 0; i < matches.Count; i++)
            {
                var currMatch = matches[i].ToString();

                var placeholderToRemove = matches[i].Groups["placeholder"].Value;

                var newMatch = currMatch.Replace(placeholderToRemove, placeholders[i]);
                input= input.Replace(currMatch, newMatch);

            }
            Console.WriteLine(input);
        }
    }
}
