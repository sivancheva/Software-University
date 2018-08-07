using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_SpyGram
{
    class SpyGram
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            var senderMessageDict = new Dictionary<string, List<string>>();
            var pattern = new Regex(@"^TO:\s{1}(?<sender>[A-Z]+);\s{1}MESSAGE:\s{1}(.*);$");
           

            while (input != "END")
            {                               
                var matchedMessage = pattern.Match(input);

                if (!matchedMessage.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string sender = matchedMessage.Groups["sender"].Value;
                int index = (matchedMessage.Length / key.Length) +1;
                var keyCurrent = string.Concat(Enumerable.Repeat(key, index))
                                            .ToCharArray().Select(x => x - 48).ToArray();

                StringBuilder result = new StringBuilder();
                               
                for (int i = 0; i < input.Length ; i++)
                {
                    var a = (int)input[i] + (keyCurrent[i]);
                                        
                    char character = (char)a;
                    string text = character.ToString();

                    result.Append(text);
                }

                if (!senderMessageDict.ContainsKey(sender))
                {
                    senderMessageDict.Add(sender, new List<string>());
                    senderMessageDict[sender].Add(result.ToString());
                }
                else if (!senderMessageDict[sender].Contains(result.ToString()))
                {
                    senderMessageDict[sender].Add(result.ToString());
                }
                              
                input = Console.ReadLine();
            }

            foreach (var sender in senderMessageDict.OrderBy(a => a.Key))
            {
                foreach (var a in sender.Value)
                {
                    Console.WriteLine($"{a}");
                }
                
            }
        }
    }
}
