using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            //if (n.Length == 0)
            //{
            //    return;
            //}
            //if (int.Parse(n) == 0)
            //{
            //    return;
            //}

            int[] array = new int[int.Parse(n)];


            var initialPositionLadybugs = Console.ReadLine()
                                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .Where(x => x >= 0 && x < array.Length)
                                            .ToArray();

            if (initialPositionLadybugs.Length == 0)
            {
                return;
            }

            foreach (var num in initialPositionLadybugs)
            {
                array[num] = 1;
            }
            var command = Console.ReadLine();
            while (command != "end")
            {
                var commandArray = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArray.Length == 3)
                {
                    int index = int.Parse(commandArray[0]);
                    string direction = commandArray[1];
                    int steps = int.Parse(commandArray[2]);

                    if (index >= 0 && index < array.Length && array[index] == 1)
                    {
                        array[index] = 0;

                        int positionToBeChecked = index;

                        if ((direction == "right" && steps >= 0) || (direction == "left" && steps < 0)) //djasna posoka
                        {
                            positionToBeChecked += Math.Abs(steps);
                        }
                        else if ((direction == "left" && steps >= 0) || (direction == "right" && steps < 0)) //ljava posoka
                        {
                            positionToBeChecked -= Math.Abs(steps);
                        }

                        while (positionToBeChecked >= 0 && positionToBeChecked < array.Length)
                        {

                            if (array[positionToBeChecked] == 1)
                            {
                                if (direction == "right")
                                {
                                    positionToBeChecked += Math.Abs(steps);
                                    continue;
                                }
                                else
                                {
                                    positionToBeChecked -= Math.Abs(steps);
                                    continue;
                                }
                            }
                            else
                            {
                                array[positionToBeChecked] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
