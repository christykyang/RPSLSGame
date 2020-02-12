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
        public Player player1;
        public Player player2;
        //public AI comp1;
        //public AI comp2;
        public string numberOfPlayers;
        //public Gesture compareGesture;
        public static List<string> ListOfGestures = new List<string> { "rock", "paper", "scissor", "lizard", "Spock" };


        //constructors
        public PlayGame()
        {
            DisplayRules();
            HowManyPlayers();
            RunGame();
        }

        //member methods
        public void DisplayRules()
        {

        }

        public void HowManyPlayers()
        {
            Console.WriteLine("How many players did you want playing?");
            numberOfPlayers = (Console.ReadLine());
            switch (numberOfPlayers)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Not a vaild option. Please try again.");
                    HowManyPlayers();
                    break;
            }
            Console.ReadLine();
            //numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == "1")
            {
                Console.WriteLine("Who is player 1?");
                player1 = new Human(Console.ReadLine());
                Console.ReadLine();
                player2 = new AI();
            }
            else //(numberOfPlayers == "2")
            {
                Console.WriteLine("Who is player 1?");
                player1 = new Human(Console.ReadLine());
                Console.WriteLine("Who is player 2?");
                player2 = new Human(Console.ReadLine());
            }
            //else
            //{
            //    player1 = new AI();
            //    player2 = new AI();
            //}

        }
        public void RunGame()
        {
            while (player1.score <= 2 && player2.score <= 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }

            DisplayWinner();
        }
        public void DisplayWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (player2.score == 3)
            {
                Console.WriteLine("Player 2 wins!");
            }

        }
        public void CompareGestures()
        {
            if (player1.gesture == ListOfGestures[0] && player2.gesture == ListOfGestures[2] || player2.gesture == ListOfGestures[3])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player1.gesture == ListOfGestures[1] && player2.gesture == ListOfGestures[0] || player2.gesture == ListOfGestures[4])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player1.gesture == ListOfGestures[2] && player2.gesture == ListOfGestures[1] || player2.gesture == ListOfGestures[3])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player1.gesture == ListOfGestures[3] && player2.gesture == ListOfGestures[4] || player2.gesture == ListOfGestures[1])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player1.gesture == ListOfGestures[4] && player2.gesture == ListOfGestures[0] || player2.gesture == ListOfGestures[2])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player2.gesture == ListOfGestures[0] && player1.gesture == ListOfGestures[2] || player1.gesture == ListOfGestures[3])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player2.gesture == ListOfGestures[1] && player1.gesture == ListOfGestures[0] || player1.gesture == ListOfGestures[4])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player2.gesture == ListOfGestures[2] && player1.gesture == ListOfGestures[1] || player1.gesture == ListOfGestures[3])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player2.gesture == ListOfGestures[3] && player1.gesture == ListOfGestures[4] || player1.gesture == ListOfGestures[1])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player2.gesture == ListOfGestures[4] && player1.gesture == ListOfGestures[0] || player1.gesture == ListOfGestures[2])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("You tied! Move on to next round.");
                Console.ReadLine();
                return;
            }
        }
    }
        //else
        //{
        //    player2.ScoredPoints();
        //}
        
    }
        

