using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Ai : Player
    {
        public Ai()
        {
            name = "Robot";
        }

        public override void ChooseGesture()
        {
            Random num = new Random();
            int rnd = num.Next(1, 6);
            switch (rnd)
            {
                case 1:
                    Console.WriteLine($"{name} Chose Rock");
                    gesture = "Rock";
                    break;
                case 2:
                    Console.WriteLine($"{name} Chose Paper");
                    gesture = "Paper";
                    break;
                case 3:
                    Console.WriteLine($"{name} Chose Scissors");
                    gesture = "Scissors";
                    break;
                case 4:
                    Console.WriteLine($"{name} Chose Lizard");
                    gesture = "Lizard";
                    break;
                case 5:
                    Console.WriteLine($"{name} Chose Spock");
                    gesture = "Spock";
                    break;
                default:
                    Console.WriteLine("Please select a gesture");
                    ChooseGesture();
                    break;
            }
        }
    }
}



