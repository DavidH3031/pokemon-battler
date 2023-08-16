using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler.Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; } = "normal";
        public int HitPoints { get; set; }
        public int AttackDamage { get; set; }
        public string AttackName { get; set; }
        public List<string> EffectiveAgainst { get; set; } = new List<string>();
        public List<string> WeakAgainst { get; set; } = new List<string>();
        public Pokemon(string name, string type, int hitPoints, int attackDamage, string attackName, List<string> effectiveAgainst, List<string> weakAgainst)
        {
            Name = name;
            Type = type;
            HitPoints = hitPoints;
            AttackDamage = attackDamage;
            AttackName = attackName;
            EffectiveAgainst = effectiveAgainst;
            WeakAgainst = weakAgainst;
        }

        public bool isEffectiveAgainst(Pokemon pokemon)
        {
            if (Type == "normal") return false;
            if (EffectiveAgainst.Contains(pokemon.Type))
            {
                Console.WriteLine($"{Name} is effective against {pokemon.Name}");
                return true;
            }else
            {
                Console.WriteLine($"{Name} is not effective against {pokemon.Name}");
                return false;
            }

        }

        public bool isWeakAgainst(Pokemon pokemon)
        {
            if (Type == "normal") return false;
            if (WeakAgainst.Contains(pokemon.Type))
            {
                Console.WriteLine($"{Name} is weak against {pokemon.Name}");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} is not weak against {pokemon.Name}");
                return false;
            }

        }
    }
}
