using pokemon_battler.PokemonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler
{
    public class Trainer
    {
        public string Name { get; set; } = string.Empty;
        public List<Pokeball> Belt { get; set; } = new List<Pokeball> {
            new Pokeball(),
            new Pokeball(),
            new Pokeball(),
            new Pokeball(),
            new Pokeball(),
            new Pokeball(),
        };

        public bool EmptyBelt = true;
        public Trainer(string name) 
        {
            Name = name;
        }

        public void Catch(Pokemon pokemon)
        {
            for(int i = 0; i < Belt.Count; i++)
            {
                if (Belt[i].Occupied == false)
                {
                    Belt[i].Throw(pokemon);
                    EmptyBelt = false;
                    break;
                }
            }
        }

        public Pokemon? GetPokemon(string pokemonName)
        {
            for (int i = 0; i < Belt.Count; i++)
            {
                if (Belt[i].Occupied == true)
                {
                    if (Belt[i].CurrentPokemon!.Name == pokemonName) return Belt[i].Throw();
                    break;
                }
            }
            Console.WriteLine("A Pokemon of that name could not be found.");
            return null;
        }
    }

    
}
