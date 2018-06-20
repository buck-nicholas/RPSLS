using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameSetup
    {
        // member variables
        // humanHuman bool (true if humanHuman, false for humanAI)
        public bool aiUsed;
        // public string scoreboard;


        // constructor
        public GameSetup()
        {
            // constructor info
            aiUsed = false;
            CreatePlayers();
        }
        // member methods
        // init gameplay
            // init scoreboard
            // init getPlayerInfo
            // if ai = true init ai
        public void CreatePlayers()
        {
            Console.WriteLine("Select Game Mode: [1] Human vs. Human or [2] Human vs. AI");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Player playerOne = new Player("Player One", true);
                playerOne.GetPlayerName();
                Player playerTwo = new Player("Player Two", true);
                playerTwo.GetPlayerName();
                Console.WriteLine("Welcome to the game " + playerOne.playerName + " and " + playerTwo.playerName);
                Console.ReadLine();
            }
            else if (userInput == "2")
            {
                Player playerOne = new Player("Player One", true);
                playerOne.GetPlayerName();
                Player playerTwo = new Player("Player Two: AI", false);
                Console.WriteLine("Welcome to the game " + playerOne.playerName + " and " + playerTwo.playerName);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have entered an invalid response, please resubmit.");
                CreatePlayers();
            }
        }
    }
}
