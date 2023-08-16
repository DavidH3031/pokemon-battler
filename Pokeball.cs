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
        public bool Occupied { get; set; }
        public Pokemon CurrentPokemon { get; set; }
        public Pokeball(bool occupied)
        {
            Occupied = occupied;
        }

        public void Throw()
        {

        }
    }
}
