using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");

            int lineNumber = 0;
            string line = reader.ReadLine();


            while (line != null)
            {
                lineNumber++;
                Console.WriteLine($"Line {lineNumber}: {line}");

            }
        }
    }
}
