using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Spyfer
{
    class Spyfer
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(long.Parse).ToList();

            for (int i = 0; i < input.Count-1; i++)
            {
                if (i == 0 && input[i] == input[i + 1])
                {
                    input.RemoveAt(i + 1);
                    i = 0;                    
                }
                else if (i == input.Count - 1 && input[input.Count - 1] == input[input.Count - 2])
                {
                    input.RemoveAt(i - 2);
                    i = 0;
                }
                else if ( i > 0 && i < input.Count- 1 && input[i] == input[i + 1] + input[i-1])
                {
                    input.RemoveAt(i - 1);
                    input.RemoveAt(i);
                    i = 0;
                }                
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
