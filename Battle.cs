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

        public Battle(Trainer player1) 
        {
            Player1 = player1;
        }
        public Battle(Trainer player1, Trainer player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}
