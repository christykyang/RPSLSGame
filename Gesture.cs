using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSGame
{
    class Gesture
    {
        //public List<Gesture> gesturesList;
        public List<string> list = new List<string>();
        //Random rndGesture = new Random();
        public bool win;

        public Gesture()
        {
            list.Add("rock");
            list.Add("paper");
            list.Add("scissor");
            list.Add("lizard");
            list.Add("Spock");
        }
        
        
        
    }
}
