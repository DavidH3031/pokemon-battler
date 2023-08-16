using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler.PokemonTypes
{
    public class Water : Pokemon
    {
        public Water(string name, string type, int hitPoints, int attackDamage, string attackName, List<string> effectiveAgainst, List<string> weakAgainst) : base(name, type, hitPoints, attackDamage, attackName, effectiveAgainst, weakAgainst)
        {
            Type = "Water";
            EffectiveAgainst.Add("Fire");
            WeakAgainst.Add("Grass");
        }
    }
}
