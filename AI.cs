using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSGame
{
    class AI : Player
    {
        //Do we need varables? (HAS A)
        Random random;
        //constructor (Spawn)
        public AI(string name, Random rng)
        {
            random = rng;
            this.name = name;
            score = 0;
            ListOfGestures = new List<string>();
            PopulateGesture(ListOfGestures);
        }
        //methods? (CAN DO)
        
        public override void ChooseGesture()
        {
            int index = random.Next(ListOfGestures.Count);
            gesture = ListOfGestures[index];
            Console.WriteLine(name + " chose " + gesture + ".");
        }
    }
}
