using System;


namespace _01_SoftUniAirline1
{
    class SoftUniAirline1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal profit = 0m;

            for (int i = 0; i < n; i++){
               
                int adults = int.Parse(Console.ReadLine());
                decimal adultsPrice = decimal.Parse(Console.ReadLine());
                int youth = int.Parse(Console.ReadLine());
                decimal youthPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumationPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal income = (decimal)adults * adultsPrice + (decimal)youth * youthPrice;
                decimal expences = flightDuration * fuelConsumationPerHour * fuelPricePerHour;
                var currProfit = income - expences;
                profit += currProfit;

                if (currProfit >= 0)
                {                    
                    Console.WriteLine($"You are ahead with {currProfit:f3}$.");
                }
                else
                {                    
                    Console.WriteLine($"We've got to sell more tickets! We've lost {currProfit:f3}$.");
                }
            }
            
            Console.WriteLine($"Overall profit -> {profit:f3}$.");
            Console.WriteLine($"Average profit -> {(profit/(decimal)n):f3}$.");
           
        }
    }
}
