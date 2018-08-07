using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            while (input != "Over!")
            {
                int n = int.Parse(Console.ReadLine());
                var pattern = new Regex($@"^(?<index1>\d+)(?<word>[a-zA-Z]{{{n}}})(?<index2>[^a-zA-Z]*)$");

                var match = pattern.Match(input);

                if (!match.Success)
                {
                    input = Console.ReadLine(); //???
                    continue;
                }
                var word = match.Groups["word"].Value;

                var index1 = match.Groups["index1"].Value.ToCharArray().Select(x => x - 48).ToList();
                var index2 = match.Groups["index2"].Value; //string
                bool allCharactersInStringAreDigits = index2.Any(char.IsDigit); // proverjavame dali ima digiti

                var indexes = new List<int>(index1);

                if (allCharactersInStringAreDigits) // ako ima digit vzimame samo tjah i gi dobavjame v list indexes
                {
                    var index2Array = index2.ToCharArray().Where(x => char.IsDigit(x)).Select(x => x - 48).ToList();
                    indexes.AddRange(index2Array);
                }

                var result = new List<char>();

                for (int i = 0; i < indexes.Count; i++)
                {
                    if (indexes[i] > word.Length - 1)
                    {
                        char space = ' ';
                        result.Add(space);
                    }
                    else
                    {
                        result.Add(word[indexes[i]]);
                    }

                }
                Console.WriteLine($"{word} == " + String.Join("", result));

                input = Console.ReadLine();
            }

        }
    }
}
