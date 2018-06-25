using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        // member variables
        
        // Constructor
        public AI()
        {
            playerName = "Computer";
            playerHuman = false;
        }
        // Member Methods
        public override int GetUserSelection()
        {
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 6);
            randomNumber -= 1;
            chosenGesture = gestureList.gestures.ElementAt(randomNumber);
            Console.WriteLine(playerName + " Has Chosen " + chosenGesture);
            return randomNumber;
        }
    }
}
