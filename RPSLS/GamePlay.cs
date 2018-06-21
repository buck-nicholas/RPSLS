using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GamePlay
    {
        // Member Variables
        public bool aiUsed;
        public Human playerOne;
        public Player playerTwo;
        public ScoreBoard scoreBoard;
        public bool winnerFound;

        public GamePlay()
        {
            playerOne = new Human("Player One");
            playerTwo = new Human("Player Two");
            aiUsed = false;
            winnerFound = false;
            DetermineGameMode();
            gamePlayMaster();
        }

        // Member Methods
        public void DetermineGameMode()
        {
            Console.WriteLine("Please select your game mode: [1] Human-Human [2] Human-Computer");
            string userInput = Console.ReadLine();
            if (userInput.Trim() == "2")
            {
                aiUsed = true;
                playerTwo = new AI();
                Console.WriteLine("***************Generating Computer**************");
            }
            else if (userInput != "1" && userInput != "2")
            {
                Console.WriteLine("You have entered an invalid selection. Please try again. Example: 1");
                DetermineGameMode();
            }

        }
        public void SetPlayerName()
        {
            if (aiUsed)
            {
                playerTwo = new AI();
            }
        }
        public void GetPlayerSelection()
        {
            int counter = 1;
            // instantiate gesture list
            Gesture gestureList = new Gesture();
            // display list
            foreach (string gesture in gestureList.gestures)
            {
                Console.WriteLine(counter + ": " + gesture);
                counter++;
            }
            // get user selection
            Console.WriteLine(playerOne.playerName + " Please choose your gesture!");
            playerOne.playerSelection = playerOne.GetUserSelection();

            if (aiUsed)
            {
                Console.WriteLine(playerTwo.playerName + " Has Chosen");
                playerTwo.playerSelection = playerTwo.GetUserSelection();
            }
            else
            {
                Console.WriteLine(playerTwo.playerName + " Please choose your gesture!");
                playerTwo.playerSelection = playerTwo.GetUserSelection();
            }
            // validate selection1
            // set selection equal to playerSelection
        }
        public void CalculateResults()
        {
            int resultCalc;
            resultCalc = (5 + playerOne.playerSelection - playerTwo.playerSelection) % 5;
            if (resultCalc == 1 || resultCalc == 3)
            {
                scoreBoard.playerOneScore++;
                Console.WriteLine(playerOne.playerName + " wins!");
            }
            else if (resultCalc == 2 || resultCalc == 4)
            {
                scoreBoard.playerTwoScore++;
                Console.WriteLine(playerTwo.playerName + " wins!");
            }
            else if (resultCalc == 0)
            {
                Console.WriteLine("It's a TIE!");   
            }
        }
        public void gamePlayMaster()
        {
            scoreBoard = new ScoreBoard(playerOne.playerName, playerTwo.playerName);
            while (!winnerFound)
            {
                GetPlayerSelection();
                CalculateResults();
                scoreBoard.DisplayScoreBoard();
                CheckWinConditions();
            }
        }
        public bool CheckWinConditions()
        {
            if (aiUsed && scoreBoard.playerTwoScore == 2)
            {
                winnerFound = true;
                Console.WriteLine("You lose, better luck next time!");
            }
            else if (scoreBoard.playerOneScore == 2)
            {
                winnerFound = true;
                Console.WriteLine("Congratulations " + playerOne.playerName + " you won!");
            }
            else if (scoreBoard.playerTwoScore == 2)
            {
                winnerFound = true;
                Console.WriteLine("Congratulations " + playerTwo.playerName + " you won!");
            }
            return winnerFound;
        }


    }
}
