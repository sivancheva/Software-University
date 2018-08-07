using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;




namespace RegexFullName
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().ToCharArray();
            int sum = arr.Select(x => (int)x).Sum();
            Console.WriteLine(sum);
        }
    }
}