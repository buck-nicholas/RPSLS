using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        // Constructor
        public Human(string playerName)
        {
            this.playerName = playerName;
        }
        // Member Methods
        public override int GetUserSelection()
        {
            Console.WriteLine(playerName + " Please choose your gesture!");
            string userInput = Console.ReadLine();
            if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5")
            {
                Console.WriteLine("You have entered an invalid variable, please try again.");
                userInput = GetUserSelection().ToString();
            }
            int convertedUserInput = int.Parse(userInput);
            convertedUserInput -= 1;
            Console.WriteLine(playerName + " Has Chosen " + (convertedUserInput + 1));
            return convertedUserInput;
        }
    }
}
