using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayManipulator2
{
    class ArrayManipulator2 //100/100
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var commandArr = Console.ReadLine().Split().ToArray();

            int[] manipulatedInput = new int[input.Length];
            Array.Copy(input, manipulatedInput, input.Length);

            while (true)
            {
                
                var command = commandArr[0];
                if (command == "end")
                {
                    break;
                }
                switch (command)
                {
                    case "exchange": ExchangeArray(manipulatedInput, int.Parse(commandArr[1]));                        
                        break;
                    case "max": MaxElement(manipulatedInput, commandArr[1]);
                        break;
                    case "min": MinElement(manipulatedInput, commandArr[1]);
                        break;

                    case "first": FirstEvenOdd(manipulatedInput, commandArr[2], int.Parse(commandArr[1]));
                        break;
                    case "last": LastEvenOdd(manipulatedInput, commandArr[2], int.Parse(commandArr[1]));
                        break;
                    default:
                        break;
                }
                commandArr = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine("[" + String.Join(", ", manipulatedInput)+"]");

        }
        static void ExchangeArray(int[] manipulatedInput, int index)
        {
            if (index >= manipulatedInput.Length || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int[] result = new int[manipulatedInput.Length];
                Array.Copy(manipulatedInput, index+1,result,0, manipulatedInput.Length-(index+1));
                Array.Copy(manipulatedInput, 0,result, manipulatedInput.Length-(index+1), index+1);
                Array.Copy(result, manipulatedInput, result.Length);
                //Console.WriteLine("["+ String.Join(" ",result) +"]");                
            }
        }
        static void MaxElement(int[] manipulatedInput, string commandEvenOrOdd)
        {
            int maxElement = 0;
            if (commandEvenOrOdd == "even")
            {
                if (manipulatedInput.All(x=>x%2 != 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    maxElement = manipulatedInput.Where(x => x % 2 == 0).Max();
                }                                         
            }
            else if(commandEvenOrOdd == "odd")
            {
                if (manipulatedInput.All(x => x % 2 == 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    maxElement = manipulatedInput.Where(x => x % 2 != 0).Max();
                }                
            }
            int indexOfMaxElement = Array.LastIndexOf(manipulatedInput, maxElement);
            if (indexOfMaxElement != -1)
            {
                Console.WriteLine(indexOfMaxElement);
            }
                    }
        static void MinElement(int[] manipulatedInput, string commandEvenOrOdd)
        {
            int minElement = 0;
            if (commandEvenOrOdd == "even")
            {
                if (manipulatedInput.All(x => x % 2 != 0))
                {
                    Console.WriteLine("No matches");                     
                }
                else
                {
                    minElement = manipulatedInput.Where(x => x % 2 == 0).Min();
                }
            }
            else if (commandEvenOrOdd == "odd")
            {
                if (manipulatedInput.All(x => x % 2 == 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    minElement = manipulatedInput.Where(x => x % 2 != 0).Min();
                }
            }
            int indexOfMinElement = Array.LastIndexOf(manipulatedInput, minElement);
            if (indexOfMinElement != -1)
            {
                Console.WriteLine(indexOfMinElement);
            }           
        }
        static void FirstEvenOdd (int[] manipulatedInput, string commandEvenOrOdd, int count)
        {
            if (count > manipulatedInput.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (commandEvenOrOdd == "even")
                {
                    Console.WriteLine("[" +String.Join(", ", manipulatedInput.Where(x => x % 2 == 0).Take(count)) + "]"); 
                }
                else
                {
                    Console.WriteLine("[" + String.Join(", ", manipulatedInput.Where(x => x % 2 != 0).Take(count)) + "]");
                }
            }
        }

        static void LastEvenOdd(int[] manipulatedInput, string commandEvenOrOdd, int count)
        {
            if (count > manipulatedInput.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (commandEvenOrOdd == "even")
                {
                    manipulatedInput = manipulatedInput.Where(x => x % 2 == 0)
                         .Reverse()
                         .Take(count)
                         .Reverse()
                         .ToArray();
                    Console.WriteLine("[" + String.Join(", ", manipulatedInput)+ "]");
                }
                else
                {
                    manipulatedInput = manipulatedInput.Where(x => x % 2 != 0)
                         .Reverse()
                         .Take(count)
                         .Reverse()
                         .ToArray();
                    Console.WriteLine("[" + String.Join(", ",manipulatedInput) + "]");
                }
            }

        }
    }
}
