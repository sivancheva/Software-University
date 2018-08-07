using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Portal
{
    class Portal
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
      
            char?[][] jagged = new char?[n][];
            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                jagged[i] = new char?[n];
                for (int j = 0; j < input.Length; j++)
                {
                    jagged[i][j] = input[j];
                    if (input[j] == 'S')
                    {
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            var commands = Console.ReadLine().ToCharArray();
            int currRow = startRow;
            int currCol = startCol;
            int stepsCounter = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'D')
                {
                    if (currRow == n - 1)
                    {
                        currRow = 0;
                        stepsCounter++;
                    }
                    else
                    {
                        currRow++;
                        stepsCounter++;
                    }

                    while (jagged[currRow][currCol] == null)
                    {
                        if (currRow == n - 1)
                        {
                            currRow = 0;
                        }
                        currRow++;
                        stepsCounter++;                       
                    }

                    if (jagged[currRow][currCol] == 'S' || jagged[currRow][currCol] == 'O')
                    {

                        continue;
                    }
                    else if (jagged[currRow][currCol] == 'E')
                    {
                        Console.WriteLine($"Experiment successful. {stepsCounter} turns required.");
                        return;
                    }
                }
                else if (commands[i] == 'U')
                {
                    if (currRow == 0)
                    {
                        currRow = n - 1;
                        stepsCounter++;
                    }
                    else
                    {
                        currRow--;
                        stepsCounter++;
                    }

                    while (jagged[currRow][currCol] == null)
                    {
                        if (currRow == 0)
                        {
                            currRow = n - 1;                           
                        }
                        currRow--;
                        stepsCounter++;
                    }
                    if (jagged[currRow][currCol] == 'S' || jagged[currRow][currCol] == 'O')
                    {

                        continue;
                    }
                    else if (jagged[currRow][currCol] == 'E')
                    {
                        Console.WriteLine($"Experiment successful. {stepsCounter} turns required.");
                        return;
                    }
                }
                else if (commands[i] == 'R')
                {
                    if (currCol == n - 1)
                    {
                        currCol = 0;
                        stepsCounter++;
                    }
                    else
                    {
                        currCol++;
                        stepsCounter++;
                    }

                    while (jagged[currRow][currCol] == null)
                    {
                        if (currCol == n - 1)
                        {
                            currCol = 0;
                        }
                        currCol++;
                        stepsCounter++;
                    }
                    if (jagged[currRow][currCol] == 'S' || jagged[currRow][currCol] == 'O')
                    {

                        continue;
                    }
                    else if (jagged[currRow][currCol] == 'E')
                    {
                        Console.WriteLine($"Experiment successful. {stepsCounter} turns required.");
                        return;
                    }
                }
                else if (commands[i] == 'L')
                {
                    if (currCol == 0)
                    {
                        currCol = n - 1;
                        stepsCounter++;
                    }
                    else
                    {
                        currCol--;
                        stepsCounter++;
                    }

                    while (jagged[currRow][currCol] == null)
                    {
                        if (currCol == 0)
                        {
                            currCol = n - 1;
                        }
                        currCol--;
                        stepsCounter++;
                    }

                    if (jagged[currRow][currCol] == 'S' || jagged[currRow][currCol] == 'O')
                    {
                        continue;
                    }
                    else if (jagged[currRow][currCol] == 'E')
                    {
                        Console.WriteLine($"Experiment successful. {stepsCounter} turns required.");
                        return;
                    }
                }

            }
            Console.WriteLine($"Robot stuck at {currRow} {currCol}. Experiment failed.");
        }
    }
}
