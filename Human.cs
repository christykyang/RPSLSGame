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

        public int score;
        public string gesture;
        public Gesture gestureList;
        public string name;

        //constructor (SPAWN)
        public Human(string name)
        {
            this.name = name;
            score = 0;
            //gestureList = new Gesture();
        }

        //member methods(CAN DO)
        public void ChooseGesture()
        {
            Console.WriteLine("Please choose a gesture from: ");
            foreach (string gesture in gestureList.list)
            {
                Console.ReadLine();
            }
            //Console.WriteLine(gesture);
            

        }
        public void HumanScoredPoints(Human human)
        {
            score++;
            Console.WriteLine(human + " wins round!");
        }
        public void HumanWins()
        { }
    }
}
