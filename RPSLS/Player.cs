using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        // member variables
        public string playerName;
        public bool humanPlayer; // if humanPlayer, set true, AI set false
        public int playerScore;

        // constructor
        public Player(string name, bool ai)
        {
            // constructor info
            playerName = name;
            humanPlayer = ai;
            playerScore = 0;
        }
        // member methods
        public void GetPlayerName()
        {
            if (humanPlayer)
            {
                Console.WriteLine("Please Enter Your Name");
                playerName = Console.ReadLine();
                if (playerName.Length == 0)
                {
                    Console.WriteLine("You have entered an invalid response, please resubmit utilizing charactors A-Z and or numbers 0-9.");
                    GetPlayerName();
                }
                Console.WriteLine("Welcome to the game " + playerName + ".");
            }
        }
    }
}
