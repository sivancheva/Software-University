using System;

public class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);


            Console.WriteLine(box.ToString());
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}

