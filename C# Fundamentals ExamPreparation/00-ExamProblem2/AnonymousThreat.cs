using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            while (true)
            {
                if (command[0] == "3:1")
                {
                    break;
                }

                switch (command[0])
                {

                    case "merge":
                        MergeElements(input, int.Parse(command[1]), int.Parse(command[2]));
                        break;

                    case "divide":
                        DivideElements(input, int.Parse(command[1]), int.Parse(command[2]));
                        break;

                }

                command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            }
            Console.WriteLine(String.Join(" ", input));
        }
        private static List<string> MergeElements(List<string> input, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= input.Count)
            {
                startIndex = 0;
            }
            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
            }
            var tempString = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                tempString += input[i];
            }
            input.RemoveRange(startIndex, (endIndex + 1) - startIndex);
            input.Insert(startIndex, tempString);
            return input.ToList();

        }
        private static List<string> DivideElements(List<string> input, int index, int count)
        {
            var inputLength = input.Count;
            string wordToSplit = input[index];
            int partsLength = wordToSplit.Length / count;

            var tempList = new List<string>();

            if (inputLength % count == 0)
            {

                for (int i = 0; i < count; i++)
                {
                    var part = wordToSplit.Substring(0, partsLength);
                    tempList.Add(part);
                    wordToSplit = wordToSplit.Remove(0, partsLength);
                }
            }
            else if (inputLength % count != 0)
            {

                for (int i = 0; i < count - 1; i++)
                {
                    var part = wordToSplit.Substring(0, partsLength);
                    tempList.Add(part);
                    wordToSplit = wordToSplit.Remove(0, partsLength);
                }
                tempList.Add(wordToSplit);
            }

            input.RemoveAt(index);
            input.InsertRange(index, tempList);
            return input;
        }

    }
}