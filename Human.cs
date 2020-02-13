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
            ListOfGestures = new List<string>();
            PopulateGesture(ListOfGestures);
        }

    //member methods(CAN DO)

    public override void ChooseGesture()
        {
            Console.WriteLine(name + ", please choose a gesture from: ");
            //PopulateGesture(ListOfGestures);
            foreach (string gesture in ListOfGestures)
            { Console.WriteLine(gesture); }

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
                case "spock":
                    break;
                default:
                    Console.WriteLine("Not an option. Try agian.");
                    ChooseGesture();
                    break;
            }
        }
    }
}
