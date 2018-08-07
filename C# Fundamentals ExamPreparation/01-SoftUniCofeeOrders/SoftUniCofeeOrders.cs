using System;
using System.Linq;
namespace SoftUniCofeeOrders
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal total = 0.0m;


            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                int capsulesAmount = int.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(date[2], date[1]);

                decimal orderPrice = (decimal)days * capsulesAmount * price;
                total += orderPrice;

                Console.WriteLine("The price for the coffee is: ${0:f2}", orderPrice);

            }

            Console.WriteLine("Total: ${0:f2}", total);

        }
    }
}