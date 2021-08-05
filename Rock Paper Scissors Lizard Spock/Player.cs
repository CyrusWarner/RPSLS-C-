using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Player
    {
        //member variables
        public string name;
        public string gesture;
        public int roundsWon;


        //constructor
        public Player()
        {
        }

        //member methods
        public virtual void ChooseGesture()
        {
            List<string> gestures = new List<string>();
            gestures.Add("(1) Rock");
            gestures.Add("(2) Paper");
            gestures.Add("(3) Scissors");
            gestures.Add("(4) Lizard");
            gestures.Add("(5) Spock");
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            Console.WriteLine($"{name} please choose a gesture using the shown numbers");
            int gestureNumber = Convert.ToInt32(Console.ReadLine());
            switch (gestureNumber)
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
