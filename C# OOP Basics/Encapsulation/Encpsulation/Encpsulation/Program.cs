using System;


public class Program
{
    static void Main(string[] args)
    {
        //length, width and height

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

