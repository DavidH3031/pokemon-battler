using pokemon_battler.PokemonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler
{
    public class Pokeball
    {
        public bool Occupied { get; set; } = false;
        public Pokemon? CurrentPokemon { get; set; }
        public Pokeball()
        {
            
        }

        public Pokemon? Throw()
        {
            if (CurrentPokemon != null)
            {
            Console.WriteLine($"{CurrentPokemon.Name} ready for battle!");
            return CurrentPokemon;
            }
            Console.WriteLine("You have no pokemon in this Pokeball");
            return null;
        }
        public void Throw(Pokemon pokemon)
        {
            if(!Occupied)
            {
                Occupied = true;
                CurrentPokemon = pokemon;
                Console.WriteLine($"You caught {pokemon.Name}!");
            }
            else
            {
                Console.WriteLine($"{CurrentPokemon!.Name} does not want to share his home use an empty Pokeball!");
            }
        }

        public bool IsEmpty()
        {
            return Occupied;
        }

        public string Contains()
        {
            if( CurrentPokemon != null )
            {
                return CurrentPokemon.Name;
            }
            return "Nobody...";
        }
    }
}
