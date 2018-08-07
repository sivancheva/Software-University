using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_AnonymousVox
{
    class AnonymousVox
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var placeholders = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();



            var pattern = new Regex(@"(?<start>[a-zA-Z]+)(?<placeholder>.+)(?<end>\1)");

            var matches = pattern.Matches(input);

            int counter = 0;

            foreach (Match item in matches)
            {
                var match = item.Value; //celiq match predi vkarvane na nov value

                string placeholder = item.Groups["placeholder"].Value;
                var strItem = item.Value.ToString();
                strItem = strItem.Replace(placeholder, placeholders[counter]);  //zamestenija Placehoder

                input = input.Replace(match, strItem);

                counter++;
            }

            Console.WriteLine(input);
        }
    }
}