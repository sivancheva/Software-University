using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs2
{
    class LadyBugs2
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var field = new int[n];

            var indexesInitial = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();

            for (int i = 0; i < indexesInitial.Length; i++)
            {
                if (indexesInitial[i] >= 0 && indexesInitial[i] < n)
                {
                    field[indexesInitial[i]] = 1;
                }
            }
            var input = Console.ReadLine();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var direction = inputArr[1];

                int index = int.Parse(inputArr[0]);
                int steps = int.Parse(inputArr[2]);
                switch (direction)
                {
                    case "right": RotateRight(field, index, steps );
                        break;
                    case "left": RotateLeft(field, index, steps);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", field));
        }

        private static int[] RotateLeft(int[] field, int index, int steps)
        {
            int positionToBeChecked = index - steps;
            
            if (index >= 0 && index < field.Length && field[index] == 1)
            {
                field[index] = 0;
                for (int i = positionToBeChecked; i >= 0; i -= steps)
                {
                    if (positionToBeChecked < 0)
                    {
                        break;
                    }
                    if (field[i] == 0 )
                    {
                        field[i] = 1;
                        break;
                    }
                }

            }
            return field;
        }

        private static int[] RotateRight(int[]field, int index, int steps)
        {
            
            int positionToBeChecked = index + steps;

            if (index >= 0 && index < field.Length && field[index] == 1 )
            {
                field[index] = 0;
                for (int i = positionToBeChecked; i < field.Length; i+=steps)
                {
                    if (positionToBeChecked>= field.Length)
                    {
                        break;
                    }
                    if(field[i] == 0)
                    {
                        field[i] = 1;
                        break;
                    }
                }                
            }
            return field;
        }
    }
}
