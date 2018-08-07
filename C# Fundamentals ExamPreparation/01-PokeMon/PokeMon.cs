using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int counter = 0;
            int pokemonPowerCurrentN = pokePowerN;

            while (!(pokemonPowerCurrentN < distanceM))
            {
                pokemonPowerCurrentN -= distanceM;
                counter++;

                if (pokePowerN / 2 == pokemonPowerCurrentN && exhaustionFactorY > 0)
                {
                    pokemonPowerCurrentN /= exhaustionFactorY;
                }


            }

            Console.WriteLine(pokemonPowerCurrentN);
            Console.WriteLine(counter);
        }
    }
}