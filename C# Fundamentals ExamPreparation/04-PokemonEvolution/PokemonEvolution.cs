using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, List<EvolutionTypeAndIndex>>();

            while (true)
            {
                if (input == "wubbalubbadubdub")
                {
                    break;
                }
                var inputArr = new List<string>();

                if (input.Contains("->"))
                {
                    inputArr = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
               
                    var pokemonName = inputArr[0];
                    EvolutionTypeAndIndex tempEvoType = new EvolutionTypeAndIndex();
                    tempEvoType.EvolutionType = inputArr[1];
                    tempEvoType.EvoIndex = int.Parse(inputArr[2]);

                    if (!result.ContainsKey(pokemonName))
                    {
                        result.Add(pokemonName, new List<EvolutionTypeAndIndex>());
                        result[pokemonName].Add(tempEvoType);
                    }
                    else
                    {
                        result[pokemonName].Add(tempEvoType);
                    }            
           
                }
                else if(!input.Contains("->"))
                {
                    if (result.ContainsKey(input))
                    {
                        foreach (var pokemon in result.Where(x => x.Key == input))
                        {
                            Console.WriteLine($"# {pokemon.Key}");
                            foreach (var item in pokemon.Value)
                            {
                                Console.WriteLine($"{item.EvolutionType} <-> {item.EvoIndex}");
                            }
                        }
                    }                    
                }
                input = Console.ReadLine();
            }
            foreach (var pokemon  in result)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var item in pokemon.Value.OrderByDescending(x=>x.EvoIndex))
                {
                    Console.WriteLine($"{item.EvolutionType} <-> {item.EvoIndex}");
                }
            }
        }
    }
    class EvolutionTypeAndIndex
    {
        public string EvolutionType{ get; set; }
        public int EvoIndex { get; set; }
    }
}
