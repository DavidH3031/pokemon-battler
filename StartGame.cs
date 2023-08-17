using pokemon_battler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battler
{

    public class StartGame
    {
        public Trainer Player1 { get; set; }
        public Trainer Player2 { get; set; }

        public StartGame(Trainer player1)
        {
            Player1 = player1;
        }
        public StartGame(Trainer player1, Trainer player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        // TODO
        // Add menu for interaction with the game.
    }
}
