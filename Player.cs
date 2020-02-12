using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSGame
{
    abstract class Player
    {
        
        public string gesture;
        public int score;
        public string name;

        //public List<string> gesturesList = new List<string>();


        public Player()
        {
            score = 0;
        }
        public abstract void ChooseGesture();
        //public Gesture(List<string> gestures)
        //{
        //    gestures.Add("rock");
        //    gestures.Add("paper");
        //    gestures.Add("scissor");
        //    gestures.Add("lizard");
        //    gestures.Add("Spock");
        //}
        public void ScoredPoints()
        {
            score++;
            Console.WriteLine("Player " + name + " wins round!");
        }



    }
}
