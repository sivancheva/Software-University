using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Entertrain
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            var lokomotivePower = int.Parse(Console.ReadLine());

            List<int> weightEachWagon = new List<int>();

            var input = Console.ReadLine();

            while (input != "All ofboard!")
            {

                int weight = int.Parse(input);
                weightEachWagon.Add(weight);

                int totalWeight = weightEachWagon.Sum();

                if (totalWeight > lokomotivePower)
                {
                    int average = (int)weightEachWagon.Average();
                    int minDifference = int.MaxValue;


                    int itemToRemove = weightEachWagon.OrderBy(item => Math.Abs(average - item)).First(); // podrejda elementite spored razlikata (average - item) i vzima purvija, nai-malkija!!!

                    int indexOfItemToRemove = weightEachWagon.IndexOf(itemToRemove);
                    weightEachWagon.RemoveAt(indexOfItemToRemove);
                }
                input = Console.ReadLine();
            }

            var reversedWeightEachWagon = new List<int>(weightEachWagon);
            reversedWeightEachWagon.Reverse();
            reversedWeightEachWagon.Add(lokomotivePower);

            Console.WriteLine(string.Join(" ", reversedWeightEachWagon));
        }
    }
}