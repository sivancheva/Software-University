using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rootFilesList = new List<string>();
            var result = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                rootFilesList.Add(input);
            }
            var searchedInfo = Console.ReadLine().Split().ToArray();
            var searchedRoot = searchedInfo[2];
            var fileExtension = searchedInfo[0];

            foreach (var file in rootFilesList)
            {
                var currFile = file.Split('\\').ToArray();
                var currRoot = currFile[0]; //
                var fileNameSize = currFile.Last().Split(';').ToArray();
                var currFileName = fileNameSize[0]; // 
                long currFileSize = long.Parse(fileNameSize[1]); //

                if (currFileName.EndsWith(fileExtension) && currRoot == searchedRoot)
                {
                    result[currFileName] = currFileSize;
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB ");
                }
            }

        }
    }
}
