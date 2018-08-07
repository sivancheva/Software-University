using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files2
{
    class Files2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var infoDict = new Dictionary<string, long>();

            var folders = new List<string>();
            for (int i = 0; i < n; i++)
            {
                folders.Add(Console.ReadLine());
            }

            var searchedInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray(); ;
            var searchedRoot = searchedInfo[2];
            var searchedExtention = searchedInfo[0];

            for (int i = 0; i < folders.Count; i++)
            {
                
                var currFolderInfo = folders[i].Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var currRoot = currFolderInfo[0];
                var fileSizeInfo = currFolderInfo[currFolderInfo.Count()-1].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                var fileName = fileSizeInfo[0];

                if (currRoot == searchedRoot && fileName.EndsWith(searchedExtention))
                {
                    long currSize = long.Parse(fileSizeInfo[1]);
                    
                        infoDict[fileName] = currSize;                   
                }
            }

            if (infoDict.Keys.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in infoDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB ");
                }
            }

        }
    }
}
