using System;


namespace _01_SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berryPrice = decimal.Parse(Console.ReadLine());


            var broiPorcii = Math.Ceiling(guests / 6);
            var priceAllDeserts = broiPorcii * (2 * bananasPrice + 4 * eggsPrice + 0.2m * berryPrice);

            if (priceAllDeserts <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceAllDeserts:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(priceAllDeserts - cash):F2}lv more.");
            }

        }
    }
}
