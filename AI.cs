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
        //public int score;
        //public string gesture;
        public Gesture gestureList;
        
        
        


        //constructor (Spawn)
        public AI()
        {
            score = 0;

        }

        //methods? (CAN DO)
        public override void ChooseGesture()
        {
            gestureList = new Gesture();
            random = new Random();

            //score = 0;
            //Random rndGesture = new Random();
            //List<string> gesturesList = new List<string> { "rock", "paper", "scissor", "lizard", "Spock" };
            int index = random.Next(gestureList.list.Count);
            string randomGesture = gestureList.list[index];
            Console.WriteLine(randomGesture);
        }
        public void CompScoredPoint()
        {
            score++;
        }
    }
}
