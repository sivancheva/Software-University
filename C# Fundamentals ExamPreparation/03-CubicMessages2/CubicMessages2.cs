using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_CubicMessages2
{
    class CubicMessages2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();            

            while (true)
            {               
                if (input == "Over!")
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                var pattern = new Regex($@"^(?<digits1>\d+)(?<message>[a-zA-Z]{{{n}}})[^a-zA-Z]*$");
                var matchedMessage = pattern.Match(input);
                
                if (matchedMessage.Success)
                {
                    string message = matchedMessage.Groups["message"].Value;
                    var digits = matchedMessage.Value.ToCharArray().Where(x => char.IsDigit(x))
                        .Select(x => x - 48).ToArray();

                    var messageToPrint = new StringBuilder();

                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (digits[i] >= message.Length)
                        {
                            messageToPrint.Append(' ');
                        }
                        else
                        {
                            messageToPrint.Append(message[digits[i]]);
                        }
                    }
                    Console.WriteLine($"{message} == {messageToPrint}");
                }
                input = Console.ReadLine();                
            }            
        }
    }
}
