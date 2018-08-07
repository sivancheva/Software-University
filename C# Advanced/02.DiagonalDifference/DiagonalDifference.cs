using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var sizeMatrix = int.Parse(Console.ReadLine());

            var matrix = new int[sizeMatrix, sizeMatrix];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < sizeMatrix; row++)
            {
                var argsOfMatrix = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row, col] = argsOfMatrix[col];

                    if (row == col)
                    {
                        primaryDiagonalSum += matrix[row, col];
                    }
                   
                }
            }

            for (int i = 0; i < sizeMatrix; i++)
            {
                
                    secondaryDiagonalSum += matrix[i, ((sizeMatrix - 1) - i)];
            }

            var sumDiagonals = Math.Abs(primaryDiagonalSum-secondaryDiagonalSum);

            Console.WriteLine(sumDiagonals);

        //    for (int i = 0; i < sizeMatrix; i++)
        //    {
        //        for (int j = 0; j < sizeMatrix; j++)
        //        {
        //            Console.Write($"{matrix[i,j]} ");
        //        }
        //        Console.WriteLine();
        //    }
        }
    }
}
