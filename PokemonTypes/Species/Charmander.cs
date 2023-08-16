using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler.PokemonTypes.Species
{
    public class Charmander : Fire
    {
        public Charmander(string name, string type, int hitPoints, int attackDamage, string attackName, List<string> effectiveAgainst, List<string> weakAgainst) : base(name, type, hitPoints, attackDamage, attackName, effectiveAgainst, weakAgainst)
        {
            AttackName = "Ember";
        }
    }
}
