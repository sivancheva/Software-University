using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var firstJaggedArr = new int[n][];
            var secondJaggedArr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();
                firstJaggedArr[i] = new int[input.Length]; //zadeljame pamet s duljina, kolkoto duljinata na input za vseki red na jagged arr!!!!!!

                for (int j = 0; j < input.Length; j++)
                {
                    firstJaggedArr[i][j] = input[j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();
                secondJaggedArr[i] = new int[input.Length]; 

                for (int j = 0; j < input.Length; j++)
                {
                    secondJaggedArr[i][j] = input[j];
                }
            }

            bool isRectangular = true; ;

            for (int i = 0; i < n-1; i++)
            {
                if (firstJaggedArr[i].Length + secondJaggedArr[i].Length != 
                    firstJaggedArr[i+1].Length + secondJaggedArr[i+1].Length)
                {
                    isRectangular = false;                    
                }
            }

            var matrixResult = new int[n][];
            if (isRectangular)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"[{String.Join(", ", firstJaggedArr[i].Concat(secondJaggedArr[i].Reverse()))}]");
                }
            }
            else
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    count += firstJaggedArr[i].Length + secondJaggedArr[i].Length;
                }
                Console.WriteLine($"The total number of cells is: {count}");
            }



            Console.WriteLine();
        }
    }
}
