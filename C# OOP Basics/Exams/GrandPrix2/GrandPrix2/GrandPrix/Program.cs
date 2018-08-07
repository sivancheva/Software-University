using System;


public class StartUp
{
    static void Main(string[] args)
    {
        var raceTower = new RaceTower();

        var numOfLaps = int.Parse(Console.ReadLine());
        var lengthOfTrack = int.Parse(Console.ReadLine());

        raceTower.SetTrackInfo(numOfLaps, lengthOfTrack);

        while (raceTower.TotalLaps != 0)
        {



        }

    }

}

