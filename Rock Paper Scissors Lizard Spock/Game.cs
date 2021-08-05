using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Game
    {
        Human playerOne;
        Human playerTwo;

        public Game()
        {

        }

        public void runGame()
        {
            Welcome();

            ChooseGameMode();

            while (playerOne.roundsWon < 3 && playerTwo.roundsWon < 3)
            {
                PlayerOneGesture();

                PlayerTwoGesture();

                DetermineWinnerOfRound();
            }
            if (playerOne.roundsWon == 3 || playerTwo.roundsWon == 3)
            {
                ShowWinnerOfGame();
            }
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Would you like to play single player or multiplayer?");
            List<string> gameModes = new List<string>();
            gameModes.Add("(1)Singleplayer");
            gameModes.Add("(2)Multiplayer");
            foreach (string gameMode in gameModes)
            {
                Console.WriteLine(gameMode);
            }
            int gameModeChoice = Convert.ToInt32(Console.ReadLine());
            switch (gameModeChoice)
            {
                case 1:
                    Console.WriteLine("You Chose Singleplayer");
                    Console.WriteLine("Please enter your name");
                    string name = Console.ReadLine();
                    playerOne = new Human(name);
                    break;
                case 2:
                    Console.WriteLine("You Chose Multiplayer");
                    Console.WriteLine("Please enter a name for player One");
                    string playerOneName = Console.ReadLine();
                    playerOne = new Human(playerOneName);
                    Console.WriteLine("Please enter a name for player two");
                    string playerTwoname = Console.ReadLine();
                    playerTwo = new Human(playerTwoname);
                    break;
                    
            }
        }
        public void PlayerOneGesture()
        {
           playerOne.ChooseGesture();
        }

        public void PlayerTwoGesture()
        {
            playerTwo.ChooseGesture();
        }

        public void DetermineWinnerOfRound()
        {
            Console.WriteLine(playerOne.gesture);
            if (playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors")
            {
                Console.WriteLine("Rock Crushes Scissors");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine("Rock Crushes Lizard");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper")
            {
                Console.WriteLine("Scissors Cuts Paper");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper")
            {
                Console.WriteLine("Scissors Decapitates Lizard");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock")
            {
                Console.WriteLine("Paper Covers Rock");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock")
            {
                Console.WriteLine("Paper Disproves Spock");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock")
            {
                Console.WriteLine("Lizard Poisons Spock");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper")
            {
                Console.WriteLine("Lizard Eats Paper");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors")
            {
                Console.WriteLine("Spock Smashes Scissors");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            if (playerOne.gesture == "Spock" && playerTwo.gesture == "Rock")
            {
                Console.WriteLine("Spocl Vaporizes Rock");
                Console.WriteLine($"{playerOne.name} won the round");
                playerOne.roundsWon += 1;
            }
            
        }
        public void ShowWinnerOfGame()
        {
            if(playerOne.roundsWon == 3)
            {
                Console.WriteLine($"{playerOne.name} has won the game!");
            }
            if(playerTwo.roundsWon == 3)
            {
                Console.WriteLine($"{playerTwo.name} has won the game!");
            }
            Console.ReadLine();

        }
    }
}
