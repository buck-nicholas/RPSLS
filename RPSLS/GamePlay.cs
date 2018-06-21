using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GamePlay
    {
        // Member Variables
        public bool aiUsed;
        public Human playerOne;
        public Player playerTwo;

        public GamePlay()
        {
            playerOne = new Human("Player One");
        }

        // Member Methods
        public void DetermineGameMode()
        {
            Console.WriteLine("Please select your game mode: [1] Human-Human [2] Human-Computer");
            string userInput = Console.ReadLine();
            if (userInput == "2")
                aiUsed = true;
            if (userInput != "1" || userInput != "2")
            {
                Console.WriteLine("You have entered an invalid selection. Please try again. Example: 1");
                DetermineGameMode();
            }
        }
        public void SetPlayerName()
        {
            if (!aiUsed)
            {
                playerTwo = new Human("Player Two");
            }
            else
            {
                playerTwo = new AI();
            }
        }
        public void GetPlayerSelection()
        {
            int counter = 0;
            // instantiate gesture list
            Gesture gestureList = new Gesture();
            // display list
            foreach (string gesture in gestureList.gestures)
            {
                Console.WriteLine(counter + gesture);
                counter++;
            }
            // get user selection
            // validate selection1
            // set selection equal to playerSelection
        }
    }
}
