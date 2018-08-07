using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {

            var listNum = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(long.Parse).ToList();
            long sumOfRemovedNums = (long)0;


            while (listNum.Count > 0)
            {
                long specialNum = (long)0;

                int index = int.Parse(Console.ReadLine());

                if (index > listNum.Count() - 1)
                {
                    specialNum = listNum.Last();
                    sumOfRemovedNums += (long)specialNum;
                    listNum[listNum.Count - 1] = listNum[0];

                }

                else if (index < 0)
                {
                    specialNum = listNum[0];
                    sumOfRemovedNums += (long)specialNum;
                    listNum[0] = listNum[listNum.Count - 1];

                }
                else
                {
                    specialNum = listNum[index];
                    sumOfRemovedNums += (long)specialNum;
                    listNum.RemoveAt(index);

                }
                for (int i = 0; i < listNum.Count; i++)
                {
                    if (listNum[i] <= specialNum)
                    {
                        listNum[i] += specialNum;
                    }
                    else
                    {
                        listNum[i] -= specialNum;
                    }
                }

            }

            Console.WriteLine(sumOfRemovedNums);
        }
    }
}