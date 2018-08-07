using System;
using System.Collections.Generic;
using System.Linq;

public class RectangleIntersection
{
    static void Main(string[] args)
    {
        var startInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int numberOfRechtangles = startInput[0];
        int numberOfIntersections = startInput[1];

        var rectangles = new Dictionary<string, Rectangle>();
        for (int i = 0; i < numberOfRechtangles; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
            var id = input[0];
            var width = double.Parse(input[1]);
            var length = double.Parse(input[2]);
            var x = double.Parse(input[3]);
            var y = double.Parse(input[4]);

            Rectangle currRectangle = new Rectangle(id, width, length, x, y);
            rectangles.Add(id, currRectangle);
        }

        for (int i = 0; i < numberOfIntersections; i++)
        {
            var rectToTest = Console.ReadLine().Split().ToArray();
            var r1 = rectToTest[i];
            var r2 = rectToTest[i+1];
            var r1ToTest = rectangles[r1];
            var r2ToTest = rectangles[r2];

            if (Rectangle.Intersect(r1ToTest, r2ToTest))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }


    }
}

