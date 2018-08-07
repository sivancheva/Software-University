using System;
using System.Linq;

namespace _01.ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            Action<string[]> print = p => Console.WriteLine(String.Join(Environment.NewLine,p));
            var names = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray();

            print(names);
        }
    }
}
