using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        // Member Variables
        public string playerName;
        public int playerSelection;
        public bool playerHuman;
        public Gesture gestureList = new Gesture();
        public string chosenGesture;

        public virtual int GetUserSelection()
        {
            string userInput = Console.ReadLine();
            int convertedUserInput = int.Parse(userInput);
            playerSelection = convertedUserInput;
            return convertedUserInput;
        }
    }
}
