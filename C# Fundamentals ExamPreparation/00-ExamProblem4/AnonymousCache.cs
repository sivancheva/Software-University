using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ExamProblem4
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dataDict = new Dictionary<string, Dictionary<string, long>>();
            var dataCache = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                
                var inputArr = input.Split(new char[] { '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                var dataSet = inputArr[0];

                if (inputArr.Length == 1)
                {                    
                    dataDict.Add(dataSet, new Dictionary<string, long>());
                                       
                }
                else if (inputArr.Length == 3)
                {
                    var dataKey = inputArr[0];
                    var dataSize = long.Parse(inputArr[1]);
                    var dataStetToCheck = inputArr[2];

                    if (dataDict.ContainsKey(dataStetToCheck) && !dataDict[dataStetToCheck].ContainsKey(dataKey))
                    {
                        dataDict[dataStetToCheck].Add(dataKey, dataSize);
                    }
                    else if (dataDict.ContainsKey(dataStetToCheck) && dataDict[dataStetToCheck].ContainsKey(dataKey))
                    {
                        dataDict[dataStetToCheck][dataKey] += dataSize;
                    }
                    else if(!dataDict.ContainsKey(dataStetToCheck) && !dataCache.ContainsKey(dataStetToCheck))
                    {
                        dataCache.Add(dataStetToCheck, new Dictionary<string, long>());
                        dataCache[dataStetToCheck].Add(dataKey, dataSize);
                    }
                    else if (!dataCache[dataStetToCheck].ContainsKey(dataKey))
                    {
                        dataCache[dataStetToCheck].Add(dataKey, dataSize);
                    }
                    else if (dataCache[dataStetToCheck].ContainsKey(dataKey))
                    {
                        dataCache[dataStetToCheck][dataKey] += dataSize;
                    }
                }
                input = Console.ReadLine();            
            }

            foreach (var item in dataCache)
            {
                if (dataDict.ContainsKey(item.Key))
                {
                    foreach (var a in item.Value)
                    {
                        var key = a.Key;
                        var size = a.Value;

                        if (!dataDict[item.Key].ContainsKey(key))
                        {
                            dataDict[item.Key].Add(key, size);
                        }
                        else
                        {
                            dataDict[item.Key][key] += size;
                        }

                    }
                }
                
            }
            foreach (var item in dataDict.OrderByDescending(x=>x.Value.Values.Sum()).Take(1))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");

                foreach (var a in item.Value)
                {
                    Console.WriteLine($"$.{a.Key}");
                }
            }
        }
    }
}
