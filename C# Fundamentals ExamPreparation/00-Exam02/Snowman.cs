using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exam02
{
    class Snowman
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToList();

            var copyOfInput = new List<int>(input);
            

            while (true)
            {

                if (input.Count == 1)
                {
                    break;
                }

                for (int i = 0; i < input.Count; i++)
                {
                    int countDiffFromTausend = copyOfInput.Where(x => x != 1000).Count();
                    if (countDiffFromTausend == 1)
                    {
                        break;
                    }

                    //if (i >= countDiffFromTausend && copyOfInput[i] == 1000)
                    //{
                    //    break;
                    //}
                    var attacker = i;
                    var target = input[i];

                    if (target > input.Count)
                    {
                        target = target % input.Count();
                    }

                    var difference = Math.Abs(attacker - target);

                    if (difference%2 == 0 && attacker != target)
                    {
                        Console.WriteLine($"{attacker} x {target} -> attacker wins");
                        copyOfInput[target] = 1000;
                    }
                    else if(difference % 2 != 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> target wins");
                    }
                    else if(attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        copyOfInput[target] = 1000;
                    }

                    
                    
                }

                copyOfInput.RemoveAll(x => x ==1000);
                input = copyOfInput;
            }

            
        }
    }
}
