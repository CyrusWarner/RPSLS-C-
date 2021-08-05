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

        public Game()
        {

        }

        public void runGame()
        {
            Welcome();

            ChooseGameMode();
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
                    break;
                    
            }
        }
    }
}
