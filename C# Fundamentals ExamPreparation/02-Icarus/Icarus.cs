using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Icarus
{
    class Icarus
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());

            var command = Console.ReadLine();
            while (true)
            {
                if (command == "Supernova")
                {
                    break;
                }
                var commandArr = command.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var direction = commandArr[0];

                switch (direction)
                {
                    case "right": Right(input, int.Parse(commandArr[1]), index);
                        break;
                    case "left":
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static void Right(int[] input, int count, int index)
        {
            int damage = 1;

            for (int i = index; i < count +index; index++)
            {
                input[index+1] -= damage;

                if (index == input.Length-1)
                {                  
                    index = -1;
                    damage++;
                    count = input.Length - (index+1);
                }                           

            }
        }
    }
}
