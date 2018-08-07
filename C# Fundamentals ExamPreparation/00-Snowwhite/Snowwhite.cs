using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var resultDict = new Dictionary<string, Dictionary<string, int>>(); //name colour physics

            var colorsDict = new Dictionary<string, int>();

            while (true)
            {
                if (input == "Once upon a time")
                {
                    break;

                }
                var inputArr = input.Split(new char[] { '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();


                var name = inputArr[0];
                var colour = inputArr[1];
                var physics = int.Parse(inputArr[2]);


                if (!resultDict.ContainsKey(name))
                {
                    resultDict.Add(name, new Dictionary<string, int>());
                    resultDict[name].Add(colour, physics);
                    if (!colorsDict.ContainsKey(colour))
                    {
                        colorsDict[colour] = 1;
                    }
                }
                if (resultDict.ContainsKey(name) && !resultDict[name].ContainsKey(colour))
                {
                    resultDict[name].Add(colour, physics);
                    if (!colorsDict.ContainsKey(colour))
                    {
                        colorsDict[colour] = 1;
                    }
                    
                        colorsDict[colour] += 1;
                    
                }
                if (resultDict.ContainsKey(name) && resultDict[name].ContainsKey(colour))
                {
                    if (resultDict[name][colour] < physics)
                    {
                        resultDict[name][colour] = physics;
                    }
                }
                                                

                input = Console.ReadLine();

            }

            var maxColour = colorsDict.OrderByDescending(x => x.Value).First().Key;

            foreach (var djudje in resultDict.OrderByDescending(x=>x.Value.Values.Max()).ThenByDescending(y=>y.Value.Where(z=>z.Key == maxColour).Count()))
            {
                
                foreach (var item in djudje.Value.OrderByDescending(x=>x.Value).ThenByDescending(z=>z.Key == maxColour))
                {
                    Console.WriteLine($"({item.Key}) {djudje.Key} <-> {item.Value}");
                }
                
            }

        }
    }
}
