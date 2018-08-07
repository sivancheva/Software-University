using System;

namespace ExerciseGenerics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var box = new GenericBox.Box<int>();
            box.Element = 123123;

            Console.WriteLine(box.ToString());            

        }
    }
}
