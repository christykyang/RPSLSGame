using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSGame
{
    class Human : Player
    {
        // variables (HAS A)

        //constructor (SPAWN)
        public Human(string name)
        {
            this.name = name;
            score = 0;
        }

        //member methods(CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine("Please choose a gesture from rock, paper, scissor, lizard and Spock.");
            gesture = (Console.ReadLine());
            switch (gesture)
            {
                case "rock":
                    break;
                case "paper":
                    break;
                case "scissor":
                    break;
                case "lizard":
                    break;
                case "Spock":
                    break;
                default:
                    Console.WriteLine("Not an option. Try agian.");
                    break;
            }
            


        }
    }
}
