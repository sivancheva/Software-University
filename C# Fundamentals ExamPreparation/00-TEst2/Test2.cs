using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_TEst2
{
    class Test2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                        
            var command = Console.ReadLine();

            while (true)
            {

                var commandArr = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

                if (command == "3:1")
                {
                    break;
                }
                if (commandArr[0] == "merge")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if (startIndex < 0 || startIndex >= input.Count)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }
                    
                    string temp = string.Empty;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        temp += input[i];

                    }
                    if (endIndex >= input.Count-1)
                    {
                        input.RemoveRange(startIndex, (input.Count-1)-startIndex);
                    }
                    else
                    {
                        input.RemoveRange(startIndex, endIndex-startIndex);
                    }                    
                    input.Insert(startIndex, temp);

                    Console.WriteLine(String.Join(" ", input));
                }
                
                else if (commandArr[0] == "divide")
                {
                    int index = int.Parse(commandArr[1]);
                    int countToDivide = int.Parse(commandArr[2]);
                    var tempList = new List<string>();

                    string wordToDivide = input[index];              

                    int coutToTake = wordToDivide.Length / countToDivide;

                    if (wordToDivide.Length % countToDivide == 0)
                    {                 
                      
                        for (int i = 0; i < countToDivide; i++)
                        {
                            string a = wordToDivide.Substring(0,coutToTake);
                            tempList.Add(a);
                            wordToDivide = wordToDivide.Remove(0,coutToTake);
                        }
                        
                    }
                    else if (wordToDivide.Length % countToDivide != 0)
                    {
                        for (int i = 0; i < countToDivide-1; i++)
                        {
                            string a = wordToDivide.Substring(0, coutToTake);
                            tempList.Add(a);
                            wordToDivide = wordToDivide.Remove(0, coutToTake);
                        }
                        tempList.Add(wordToDivide);
                    }
                    input.RemoveAt(index);
                    input.InsertRange(index, tempList);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
