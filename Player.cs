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
        public List<string> ListOfGestures;
        //public List<string> ListOfGestures = new List<string>() { "rock" , "paper" , "scissor" , "lizard" , "spock"};


        public Player()
        {
            score = 0;
        }
        public abstract void ChooseGesture();
        public void PopulateGesture(List<string> gestures)
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissor");
            gestures.Add("lizard");
            gestures.Add("spock");
            //foreach (string gesture in ListOfGestures)
            //{ Console.WriteLine(gesture); }
        }

        public void PlayerScoredPoints()
        {
            score++;
        }



    }
}
