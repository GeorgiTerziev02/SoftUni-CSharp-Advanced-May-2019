using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input.ToLower() != "tournament")
            {
                string[] playerInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = playerInfo[0];
                string pokemon = playerInfo[1];
                string element = playerInfo[2];
                int health = int.Parse(playerInfo[3]);

                var newPokemon = new Pokemon(pokemon, element, health);

                if (!ContainsTrainer(trainers, name))
                {
                    var list = new List<Pokemon>();
                    list.Add(newPokemon);

                    Trainer trainer = new Trainer(name, 0, list);
                    trainers.Add(trainer);
                }
                else
                {
                    // Trainer foundTrainer = 
                    FindTrainer(trainers, name).Collection.Add(newPokemon);
                    //foundTrainer.Collection.Add(newPokemon);         
                }
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while(command.ToLower()!="end")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    Trainer currentTrainer = trainers[i];
                    bool b = false;
                    foreach (var pokemon in currentTrainer.Collection)
                    {
                        if (pokemon.Element == command) b = true;
                    }
                    if(b==true)
                    {
                        currentTrainer.Badges++;
                    }
                    else
                    {
                        for (int j = 0; j < currentTrainer.Collection.Count; j++)
                        {
                            Pokemon currentPokemon = currentTrainer.Collection[j];
                            currentPokemon.Health -= 10;

                            if(currentPokemon.Health<=0)
                            {
                                currentTrainer.Collection.Remove(currentPokemon);
                            }
                        }

                    }
                }
                command = Console.ReadLine();
            }

            foreach (var player in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{player.Name} {player.Badges} {player.Collection.Count}");
            }

        }

        private static Trainer FindTrainer(List<Trainer> trainers, string name)
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i].Name == name) return trainers[i];
            }
            return trainers[0];
        }

        private static bool ContainsTrainer(List<Trainer> trainers, string name)
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i].Name == name) return true;
            }
            return false;
        }
    }
}
