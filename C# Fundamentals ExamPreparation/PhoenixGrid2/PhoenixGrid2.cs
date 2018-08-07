using System;
using System.Text.RegularExpressions;

namespace PhoenixGrid2
{
    class PhoenixGrid2
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var pattern = new Regex(@"^([^_\s]{3})(\.[^_\s]{3})*$");

            while (true)
            {
                if (input == "ReadMe")
                {
                    break;
                }

                var validMessage = pattern.Match(input);

                if (validMessage.Success && IsPalindorm(validMessage.ToString()))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }

        private static bool IsPalindorm(string validMessage)
        {
            int lengthOfMessage = validMessage.Length;
            string firstHalf = validMessage.Substring(0, lengthOfMessage / 2);
            string secondHalf = validMessage.Substring((lengthOfMessage / 2 + 1));
            char[] charArray = secondHalf.ToCharArray();
            Array.Reverse(charArray);
            var reversedSecondHalf=  new string(charArray);

            if (firstHalf.Equals(reversedSecondHalf))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
