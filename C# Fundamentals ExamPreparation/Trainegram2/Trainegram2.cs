using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainegram2
{
    class Trainegram2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (true)
            {
                if (input == "Traincode!")
                {
                    break;
                }

                var pattern = new Regex(@"^(<\[[^a-zA-Z0-9]*\]\.){1}(\.\[[a-zA-Z0-9]*\]+\.)*$");
                var validTrain = pattern.Match(input);

                if (validTrain.Success)
                {
                    Console.WriteLine(validTrain.ToString());
                }
                input = Console.ReadLine();
            }
        }
    }
}
