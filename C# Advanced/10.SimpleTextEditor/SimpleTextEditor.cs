using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var text = new StringBuilder();
            var history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();

                var command = inputArgs[0];
                
                switch (command)
                {

                    case "1":
                        text.Append(inputArgs[1]);
                        history.Push(text.ToString());
                        break;
                    case "2":

                        int countToDelete = int.Parse(inputArgs[1]);
                        history.Push(text.ToString());

                        if (countToDelete > text.Length)
                        {
                            text.Clear();
                            break;
                        }
                        text.Remove(text.Length-countToDelete, countToDelete);
                        
                        break;

                    case "3":
                        int index = int.Parse(inputArgs[1]);

                        if (index <= text.Length && index > 0)
                        {

                            char letterToFind = text.ToString().ElementAt(index - 1);
                            Console.WriteLine($"{letterToFind}");
                         
                        }
                        break;

                    case "4":
                        text.Clear();
                        text.Append(history.Pop());
                        break;
                    default:
                        break;
                }
            }
        }

       
    }
}
