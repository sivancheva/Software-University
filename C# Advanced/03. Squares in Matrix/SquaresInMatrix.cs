using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Squares_in_Matrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rowCount = input[0];
            var colCount = input[1];
            var matrix = new char[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                var argsMatrix = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int c = 0; c < colCount; c++)
                {
                    matrix[r, c] = argsMatrix[c];
                }
            }

            int squareMatrixCount = 0;

            for (int r = 0; r < rowCount-1; r++)
            {
                for (int c = 0; c < colCount-1; c++)
                {
                    if ((matrix[r,c] == matrix[r,c+1]) &&
                        (matrix[r+1, c]) == (matrix[r+1, c+1])&&
                        (matrix[r,c] == matrix[r+1,c]))
                    {
                        squareMatrixCount++;
                    }
                }
            }
            Console.WriteLine(squareMatrixCount);

        }
    }
}
