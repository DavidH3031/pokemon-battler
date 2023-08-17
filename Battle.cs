using pokemon_battler.PokemonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler
{
    public class Battle
    {
        public Trainer Player1 { get; set; }
        public Trainer Player2 { get; set; } = new Trainer("Kevin");
        public bool Player1Turn { get; set; } = true;

        public Battle(Trainer player1) 
        {
            Player1 = player1;
        }
        public Battle(Trainer player1, Trainer player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void Fight(Pokemon atkPokemon, Pokemon dfdPokemon)
        {
            Console.WriteLine($"{atkPokemon.Name} is on the attack!");
            if (atkPokemon == null) Console.WriteLine("You must have an attacking pokemon to fight");
            if (dfdPokemon == null) Console.WriteLine("You must have a defending pokemon to fight");

            if(atkPokemon != null && dfdPokemon != null)
            {
                dfdPokemon.TakeDamage(atkPokemon.UseAttack());
            }
        }
    }
}
