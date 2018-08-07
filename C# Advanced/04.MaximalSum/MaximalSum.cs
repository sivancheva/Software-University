using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rowCount = input[0];
            var colCount = input[1];
            var matrix = new int[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                var martixArgs = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int c = 0; c < colCount; c++)
                {
                    matrix[r, c] = martixArgs[c];
                }
            }

            int maxSum = int.MinValue;
            int rMax = 0;
            int cMax = 0;

            for (int r = 0; r < rowCount-2; r++)
            {
                
                for (int c = 0; c < colCount-2; c++)
                {
                    int currentSum = 0;
                    currentSum += matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                                    matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                                    matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rMax = r;
                        cMax = c;
                    }
                }
                
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int r = rMax; r <= rMax+2; r++)
            {
                for (int c = cMax; c <= cMax+2; c++)
                {
                    Console.Write($"{matrix[r,c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}


//4 5
//1 5 5 2 4
//2 1 4 14 3
//3 7 11 2 8
//4 8 12 16 
