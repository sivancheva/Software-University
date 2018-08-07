using System;


public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ';'}, StringSplitOptions.RemoveEmptyEntries);
            if (input.Length != 3)
            {
                Console.WriteLine("Invalid song.");
            }
            else
            {

            }

        }

       

    }
}

