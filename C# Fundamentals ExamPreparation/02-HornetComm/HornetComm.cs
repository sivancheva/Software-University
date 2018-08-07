using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var messagePattern = new Regex(@"^([\d]+) <-> ([a-zA-Z0-9]+)$");
            var broadcastPattern = new Regex(@"^([^\d]+) <-> ([a-zA-Z0-9]+)$");

            var messageResultList = new List<string>();
            var broadcastResultList = new List<string>();

            while (input != "Hornet is Green")
            {
                var matchMessage = messagePattern.Match(input);
                var matchBroadcast = broadcastPattern.Match(input);

                if (matchMessage.Success)
                {
                    var messageArr = input.Split(new string[] { "<->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    var recipientChar = messageArr[0].ToCharArray();
                    Array.Reverse(recipientChar);

                    var recipient = new string(recipientChar);
                    var message = messageArr[1];

                    string resultMessage = recipient + " -> " + message;
                    messageResultList.Add(resultMessage);

                }
                else if (matchBroadcast.Success)
                {
                    var broadcastArr = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                    var message = broadcastArr[0];
                    var frequency = broadcastArr[1];

                    StringBuilder builder = new StringBuilder();

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        char a = frequency[i];
                        if (char.IsLower(a))
                        {
                            a = Char.ToUpper(a);

                        }
                        else if (char.IsUpper(a))
                        {
                            a = Char.ToLower(a);

                        }

                        builder.Append(a);
                    }
                    string resultMessage = builder + " -> " + message;
                    broadcastResultList.Add(resultMessage);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcastResultList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcastResultList)
                {
                    Console.WriteLine(broadcast);
                }
            }

            Console.WriteLine("Messages:");

            if (messageResultList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var privat in messageResultList)
                {
                    Console.WriteLine(privat);
                }
            }


        }
    }
}