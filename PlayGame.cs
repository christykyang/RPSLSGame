using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSGame
{
    class PlayGame
    {
        //member variables
        public Human player1;
        public Human player2;
        public AI comp;
        public int numberOfPlayers;
        public Gesture compareGesture;


        //constructors
        public PlayGame()
        {
            Console.WriteLine("How many players did you want playing?");
            numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 1)
            {
                Console.WriteLine("Who is player 1");
                player1 = new Human(Console.ReadLine());
                comp = new AI();
                RunOnePlayerGame();
            }
            else
            {
                Console.WriteLine("Who is player 1?");
                player1 = new Human(Console.ReadLine());
                Console.WriteLine("Who is player 2?");
                player2 = new Human(Console.ReadLine());
                RunMultiplayerGame();
            }
        }

        //member methods
        public void RunOnePlayerGame()
        {
            
        }
        public void RunMultiplayerGame()
        {
            Console.WriteLine("Who is player 1?");
            
            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareMultiPlayerGestures();
            }
            DisplayWinner();
            Console.ReadLine();
        }
        public void RunGame(Gesture gesture)
        {
            while (player1.score < 2 && player2.score < 2)
            {

            }
        }
        public void CompareMultiPlayerGestures()
        {
            if (player1.gesture == compareGesture.list[0] && player2.gesture == compareGesture.list[2] || player2.gesture == compareGesture.list[3])
            {
                player1.HumanScoredPoints(player1);   
            }
            if (player1.gesture == compareGesture.list[1] && player2.gesture == compareGesture.list[0] || player2.gesture == compareGesture.list[4])
            {
                player1.HumanScoredPoints(player1);
            }
            if (player1.gesture == compareGesture.list[2] && player2.gesture == compareGesture.list[1] || player2.gesture == compareGesture.list[3])
            {
                player1.HumanScoredPoints(player1);
            }
            if (player1.gesture == compareGesture.list[3] && player2.gesture == compareGesture.list[4] || player2.gesture == compareGesture.list[1])
            {
                player1.HumanScoredPoints(player1);
            }
            if (player1.gesture == compareGesture.list[4] && player2.gesture == compareGesture.list[0] || player2.gesture == compareGesture.list[2])
            {
                player1.HumanScoredPoints(player1);
            }
            else
            {
                player2.HumanScoredPoints(player2);
            }
        }
        public void DisplayWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
        }
    }
}
