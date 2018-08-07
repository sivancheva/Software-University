using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TrophonTheGrumpyCat
{
    class TrophonTheGrumpyCat
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputArray = input.Split(' ').Select(long.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            var middleElement = inputArray[index];

            var command = Console.ReadLine();
            var priceRating = Console.ReadLine();

            var leftArr = new List<long>(inputArray);
            leftArr.RemoveRange((index), (inputArray.Length - (index)));
            long leftSum = 0;

            var rightArr = new List<long>(inputArray);
            rightArr.RemoveRange(0, (index + 1));
            long rightSum = 0;

            if (command == "cheap")
            {
                if (priceRating == "positive")
                {
                    leftSum = leftArr.Where(x => x < middleElement && x > 0).Sum();
                    rightSum = rightArr.Where(x => x < middleElement && x > 0).Sum();
                }
                else if (priceRating == "negative")
                {
                    leftSum = leftArr.Where(x => x < middleElement && x < 0).Sum();
                    rightSum = rightArr.Where(x => x < middleElement && x < 0).Sum();
                }
                else
                {
                    leftSum = leftArr.Where(x => x < middleElement).Sum();
                    rightSum = rightArr.Where(x => x < middleElement).Sum();
                }
            }
            else if (command == "expensive")
            {
                if (priceRating == "positive")
                {
                    leftSum = leftArr.Where(x => x >= middleElement && x > 0).Sum();
                    rightSum = rightArr.Where(x => x >= middleElement && x > 0).Sum();
                }
                else if (priceRating == "negative")
                {
                    leftSum = leftArr.Where(x => x >= middleElement && x < 0).Sum();
                    rightSum = rightArr.Where(x => x >= middleElement && x < 0).Sum();
                }
                else
                {
                    leftSum = leftArr.Where(x => x >= middleElement).Sum();
                    rightSum = rightArr.Where(x => x >= middleElement).Sum();
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else if (leftSum < rightSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }

        }
    }
}
