using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //var dictionary = new Dictionary<string, NameSizeFiles>();

            var dictionary = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();


                var inputArr = input.Split('\\').Select(x => x.Trim()).ToArray();
                var root = inputArr.First();
                var fileName = inputArr.Last().Split(';').First();
                long fileSize = long.Parse(inputArr.Last().Split(';').Last());

                if (!dictionary.ContainsKey(root))
                {
                    dictionary.Add(root, new Dictionary<string, long>());
                }
                if (dictionary.ContainsKey(root))
                {
                    if (dictionary[root].ContainsKey(fileName))
                    {
                        dictionary[root][fileName] = fileSize;
                    }
                    else
                    {
                        dictionary[root].Add(fileName, fileSize);
                    }
                }

            }
            var command = Console.ReadLine().Split().Select(x => x.Trim()).ToArray();
            var rootForSearch = command[2];
            var extentionForSearch = command[0];

            if (!dictionary.ContainsKey(rootForSearch))
            {
                Console.WriteLine("No");
                return;
            }


            var dict = dictionary[rootForSearch];

            var dictionaryRootForSearch = dict
                                        .Where(a => a.Key.EndsWith(extentionForSearch))
                                        .OrderByDescending(a => a.Value)
                                        .ThenBy(a => a.Key).ToArray();

            if (dictionaryRootForSearch.Length < 1)
            {
                Console.WriteLine("No");
            }

            foreach (var pair in dictionaryRootForSearch)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} KB ");
            }


        }
    }

}

//class NameSizeFiles
//{
//    public string FileName { get; set; }
//    public long FileSize { get; set; }
//}
