using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ScoreBoard
    {
        // member variables
        public string playerOneName;
        public string playerTwoName;
        public int playerOneScore;
        public int playerTwoScore;
        // Constructor
        public ScoreBoard(string playerOne, string playerTwo)
        {
            playerOneName = playerOne;
            playerTwoName = playerTwo;
            playerOneScore = 0;
            playerTwoScore = 0;
            DisplayScoreBoard();
        }
        // member methods
        public void DisplayScoreBoard()
        {
            Console.WriteLine("The score is: " + playerOneName + " " + playerOneScore + " to " + playerTwoName + " " + playerTwoScore);
        }
    }
}
