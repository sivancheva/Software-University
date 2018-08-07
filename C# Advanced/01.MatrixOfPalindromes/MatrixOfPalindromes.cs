using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            var inputArgs = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rowLen = inputArgs[0];
            var colLen = inputArgs[1];


            for (int row = 0; row < rowLen; row++)
            {
        
                for (int col = 0; col < colLen; col++)
                {

                    char letterRow = (char)('a' + row);
                    char letterCol = (char)(letterRow + col);

                    Console.Write($"{letterRow}{letterCol}{letterRow} ");

                }
              
                Console.WriteLine();
            }
        }
    }
}
