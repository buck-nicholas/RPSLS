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
        public int playerScore;
        public int playerSelection;
        public bool playerHuman;

        public virtual int GetUserSelection()
        {
            string userInput = Console.ReadLine();
            int convertedUserInput = int.Parse(userInput);
            playerSelection = convertedUserInput;
            return convertedUserInput;
        }
    }
}
