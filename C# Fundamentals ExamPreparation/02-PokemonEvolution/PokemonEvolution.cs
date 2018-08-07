using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_PokemonEvolution
{

    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var resultDictionary = new Dictionary<string, List<PokemeonEvolutionIndex>>();

            while (input != "wubbalubbadubdub")
            {
                var inputArray = Regex.Split(input, @"->").Select(x => x.Trim()).ToArray();
                var pokemonName = inputArray[0];

                if (inputArray.Length == 1 && resultDictionary.ContainsKey(pokemonName))
                {
                    Console.WriteLine($"# {pokemonName}");
                    foreach (var item in resultDictionary[pokemonName])
                    {
                        Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                    }
                    input = Console.ReadLine();
                    continue;
                }
                var evolutionType = inputArray[1];
                var pokemonNameIsValid = pokemonName.IndexOfAny(new char[] { '-', ' ', '>' }) == -1;
                var evolutionTypeIsValid = evolutionType.IndexOfAny(new char[] { '-', ' ', '>' }) == -1;

                if (!pokemonNameIsValid || !evolutionTypeIsValid)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var evolutionIndex = int.Parse(inputArray[2]);

                var newEvolution = new PokemeonEvolutionIndex();
                newEvolution.EvolutionType = evolutionType;
                newEvolution.EvolutionIndex = evolutionIndex;

                if (!resultDictionary.ContainsKey(pokemonName))
                {
                    resultDictionary.Add(pokemonName, new List<PokemeonEvolutionIndex>());
                }
                resultDictionary[pokemonName].Add(newEvolution);


                input = Console.ReadLine();
            }
            foreach (var item in resultDictionary)
            {
                Console.WriteLine($"# {item.Key}");

                foreach (var pokemon in item.Value.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{pokemon.EvolutionType} <-> {pokemon.EvolutionIndex}");
                }
            }

        }
    }
}

class PokemeonEvolutionIndex
{
    public string EvolutionType { get; set; }
    public int EvolutionIndex { get; set; }
}