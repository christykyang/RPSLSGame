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
        }

        public void PlayerScoredPoints()
        {
            score++;
        }



    }
}
