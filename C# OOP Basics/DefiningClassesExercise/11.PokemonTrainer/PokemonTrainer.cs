using System;
using System.Collections.Generic;
using System.Linq;


public class PokemonTrainer
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();

        var trainers = new Dictionary<string, Trainer>();

        while (command != "Tournament")
        {
            var inputArr = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            //TrainerName > < PokemonName > < PokemonElement > < PokemonHealth >”
            var trainerName = inputArr[0];
            var pokemonName = inputArr[1];
            var pokemonElement = inputArr[2];
            var pokemonHealth = int.Parse(inputArr[3]);

            var currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            AddTrainersAndPokemons(trainers, trainerName, currPokemon);
            command = Console.ReadLine();
        }

        var element = Console.ReadLine();

        while (element  != "End")
        {

            foreach (var trainer in trainers)
            {
                if (trainer.Value.Pokemons.Any(x=>x.Element == element))
                {
                    trainers[trainer.Key].NumberOfBadges++;
                }
                else
                {
                    trainers[trainer.Key].Pokemons.Select(x => x.Health -= 10);
                }

            }

            var nonMatchingTrainerd = trainers.Values.Where(t => t.Pokemons.All(p => p.Element != element));

            foreach (var trainer in nonMatchingTrainerd)
            {
                trainer.Pokemons.ForEach(p => p.Health -= 10);
                trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0)
                                                    .ToList();
            }
            
            element = Console.ReadLine();
        }

        foreach (var t in trainers.Values.OrderByDescending(x=>x.NumberOfBadges))
        {
            Console.WriteLine($"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count}");
        }
    }

    private static void AddTrainersAndPokemons(Dictionary<string, Trainer> trainers, string trainerName, Pokemon currPokemon)
    {
        if (!trainers.ContainsKey(trainerName))
        {
            var trainerToAdd = new Trainer(trainerName, currPokemon);
            trainers.Add(trainerName, trainerToAdd);
            trainers[trainerName].Pokemons.Add(currPokemon);
        }
        else
        {
            trainers[trainerName].Pokemons.Add(currPokemon);
        }
    }
}

