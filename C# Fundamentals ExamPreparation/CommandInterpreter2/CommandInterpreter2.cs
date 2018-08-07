using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter2
{
    class CommandInterpreter2
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var commands = Console.ReadLine();

            while (true)
            {
                if (commands == "end")
                {
                    break;
                }
                
                var commandArr = commands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                var command = commandArr[0];

                switch (command)
                {
                    case "reverse": Reverse(inputArr, int.Parse(commandArr[2]), int.Parse(commandArr[4]));
                        break;
                    case "sort": Sort(inputArr, int.Parse(commandArr[2]), int.Parse(commandArr[4]));
                        break;
                    case "rollLeft": RollLeft(inputArr, int.Parse(commandArr[1]));
                        break;
                    case "rollRight": RollRight(inputArr, int.Parse(commandArr[1]));
                        break;
                }
                commands = Console.ReadLine();
            }
            
            Console.WriteLine("["+ String.Join(", ", inputArr) + "]");
        }

        
        private static string[] Reverse(string[] inputArr, int start, int count)
        {
            if (start >=0 && start < inputArr.Length && count >=0 && start + count <= inputArr.Length )
            {
                Array.Reverse(inputArr, start, count);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

            return inputArr;
        }

        private static string[] Sort(string[] inputArr, int start, int count)
        {
           
            if (start >= 0 && start < inputArr.Length && count >= 0 && start + count <= inputArr.Length)
            {
                Array.Sort(inputArr, start, count);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
            return inputArr;
        }

        private static string[] RollLeft(string[] inputArr, int count)
        {
            var tempList = new List<string>(inputArr);
            if (count >= 0)
            {
                for (int i = 0; i < count%inputArr.Length; i++)
                {
                    
                    tempList.Add(tempList[0]);
                    tempList.RemoveAt(0);
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

            Array.Copy(tempList.ToArray(), inputArr, tempList.Count());
            return inputArr;
        }

        private static string[] RollRight(string[] inputArr, int count)
        {
            var tempList = new List<string>(inputArr);
            if (count >= 0)
            {
                for (int i = 0; i < count % inputArr.Length; i++)
                {

                    tempList.Insert(0, tempList.Last());
                    tempList.RemoveAt(tempList.Count-1);
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

            Array.Copy(tempList.ToArray(), inputArr, tempList.Count());
            return inputArr;
        }
    }
}
