using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RubiksMatrix
{
    class RubiksMatrix
    {
        private static int[,] matrix;
        private static int rowCount;
        private static int colCount;


        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            rowCount = input[0];
            colCount = input[1];
            matrix = new int[rowCount, colCount];

            FillStartMatrix(matrix);
            //PrintMatrix(matrix);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var index = int.Parse(command[0]);
                var direction = command[1].ToLower();
                var moves = int.Parse(command[2]);

                switch (direction)
                {
                    case "up":
                        RollUp(index, moves);
                        break;
                    case "down":
                        RollDown(index, moves);
                        break;
                    case "left":
                        RollLeft(index, moves);
                        break;
                    case "right":
                        RollRight(index, moves);
                        break;
                }
            }
                        
            SwapMatrix(matrix);
        }

        private static void FillStartMatrix(int[,] matrix)
        {
            int counter = 1;
            for (int r = 0; r < rowCount; r++)
            {

                for (int c = 0; c < colCount; c++)
                {
                    matrix[r, c] = counter;
                    counter++;
                }
            }
        }

        private static void SwapMatrix(int[,] matrix)
        {
            int searchedNumber = 1;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    int currNum = matrix[r, c];
                    if (currNum == searchedNumber)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            for (int j = 0; j < colCount; j++)
                            {
                                if (matrix[i, j] == searchedNumber)
                                {
                                    int tempNum = matrix[r,c];
                                    matrix[i, j] = tempNum;
                                    matrix[r, c] = searchedNumber;
                                   // PrintMatrix(matrix);
                                    Console.WriteLine($"Swap ({r}, {c}) with ({i}, {j})");
                                }
                            }
                        }
                    }
                    searchedNumber++;
                }

            }
        }

        private static void RollRight(int index, int moves)
        {
            var listTemp = new List<int>();

            CopyRowOfMatrix(index, listTemp);

            if (index >= 0 && index < colCount && moves >= 0)
            {
                int movesShort = moves % colCount;

                for (int i = 0; i < movesShort; i++)
                {
                    var numToInsert = listTemp[listTemp.Count-1];
                    listTemp.RemoveAt(listTemp.Count -1);
                    listTemp.Insert(0,numToInsert);

                }

                for (int c = 0; c < colCount; c++)
                {
                    matrix[index, c] = listTemp[c];
                }
            }
           // PrintMatrix(matrix);
        }

        private static void RollLeft(int index, int moves)
        {
            var listTemp = new List<int>();

            CopyRowOfMatrix(index, listTemp);

            if (index >= 0 && index<colCount && moves >= 0)
            {
                int movesShort = moves % colCount;
                
                for (int i = 0; i < movesShort; i++)
                {
                    var numToInsert = listTemp[0];
                    listTemp.RemoveAt(0);
                    listTemp.Add(numToInsert);

                }

                for (int c = 0; c < colCount; c++)
                {
                    matrix[index, c] = listTemp[c];
                }
            }
                       
            
            //PrintMatrix(matrix);
        }

        private static void RollDown(int index, int moves)
        {
            int movesShort = moves % rowCount;
            var listRow = new List<int>();

            if (index>=0 && index < rowCount && moves>=0)
            {
                for (int r = 0; r < rowCount; r++)
                {
                    listRow.Add(matrix[r, index]);
                }
                for (int i = 0; i < movesShort; i++)
                {
                    int numToInsert = listRow.Last();
                    listRow.RemoveAt(listRow.Count-1);
                    listRow.Insert(0,numToInsert);

                }
                for (int i = 0; i < rowCount; i++)
                {
                    matrix[i, index] = listRow[i];
                }
            }

           //PrintMatrix(matrix);
        }

        private static void RollUp(int index, int moves)
        {
            int movesShort = moves % rowCount;
            var listRow = new List<int>();


            if (index >= 0 && index < rowCount && moves >= 0)
            {
                for (int r = 0; r < rowCount; r++)
                {
                    listRow.Add(matrix[r, index]);
                }

                for (int i = 0; i < movesShort; i++)
                {
                    int numToInsert = listRow.First();
                    listRow.RemoveAt(0);
                    listRow.Add(numToInsert);
                }
                for (int i = 0; i < rowCount; i++)
                {
                    matrix[i, index] = listRow[i];
                }
            }

          //PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(String.Join(" ", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }

        private static void CopyRowOfMatrix(int index, List<int> listTemp)
        {
            
        for (int c = 0; c < colCount; c++)
        {
            listTemp.Add(matrix[index, c]);
        }
            
        }
    }
}
