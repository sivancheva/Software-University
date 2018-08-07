using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Trainegram
{
    class Trainegram
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var pattern = new Regex(@"^(?<lokomotiv><\[([^a-zA-Z0-9]*)\]\.{1})(?<wagon>\.\[([a-zA-Z0-9]*)\]\.)*$");

            while (input != "Traincode!")
            {
                var matchedInput = pattern.Match(input);

                if (matchedInput.Success)
                {
                    Console.WriteLine(matchedInput);
                }

                input = Console.ReadLine();
            }

        }
    }
}