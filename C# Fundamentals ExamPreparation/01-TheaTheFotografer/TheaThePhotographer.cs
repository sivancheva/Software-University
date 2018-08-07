using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int takenPictures = int.Parse(Console.ReadLine());
            int timeFiltering = int.Parse(Console.ReadLine());
            int amoutGoodPictures = int.Parse(Console.ReadLine());
            int timeUploading = int.Parse(Console.ReadLine());

            decimal usefullPictures = Math.Ceiling((decimal)(takenPictures * ((decimal)amoutGoodPictures / 100m)));
            long timeFilteringTotal = (long)takenPictures * timeFiltering;
            long timeUpload = (long)usefullPictures * timeUploading;

            long totalTime = timeFilteringTotal + timeUpload; //sec

            TimeSpan t = TimeSpan.FromSeconds(totalTime);

            string answer = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                t.Days,
                t.Hours,
                t.Minutes,
                t.Seconds);

            Console.WriteLine(answer);
        }
    }
}