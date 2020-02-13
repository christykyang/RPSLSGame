﻿using System;
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
        public AI()
        {
            score = 0;
            name = "Computer";
            ListOfGestures = new List<string>();
            PopulateGesture(ListOfGestures);
        }
        //methods? (CAN DO)
        
        public override void ChooseGesture()
        {
            random = new Random();
            int index = random.Next(ListOfGestures.Count);
            gesture = ListOfGestures[index];
            Console.WriteLine(name + " chose " + gesture + ".");
        }
    }
}
