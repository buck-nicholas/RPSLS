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
            playerScore = 0;
            playerHuman = false;
        }

        // Member Methods
        //public void GenterateRandomNumber()
        //{
        //    // generate a whole number between 1 and 5 inclusive
        //    // set random number to playerSelection
        //    Random rnd = new Random();
        //    playerSelection = rnd.Next(1, 6);
        //}
        public override int GetUserSelection()
        {
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1,6);
            Console.WriteLine("At AI CS: " + randomNumber);
            return randomNumber;
        }
    }
}
