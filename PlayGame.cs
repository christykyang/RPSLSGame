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
        public string playAgain;
        public string numberOfPlayers;
        public string rulesList;
        //constructors
        public PlayGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard, Spock!");
            Console.ReadLine();
            DisplayRules();
        }
        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("Do you need the list of rules?");
            rulesList = (Console.ReadLine());
            if (rulesList == "yes")
            {
                Console.WriteLine("Rock crushes Scissor");
                Console.WriteLine("Scissor cuts paper");
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("Spock smashes Scissor");
                Console.WriteLine("Scissor decapitates Lizard");
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Spock vaporizes Rock");
                Console.ReadLine();
                RunGame();
            }
            else if (rulesList == "no")
            {
                RunGame();
            }
            else
            {
                Console.WriteLine("Please choose yes or no.");
                DisplayRules();
            }
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
            Console.WriteLine("Let's play!");
            HowManyPlayers();
            while (player1.score <= 2 && player2.score <= 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }

            DisplayWinner();
            PlayAgain();
        }
        public void DisplayWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine(player1.name + " wins!");
            }
            else if (player2.score == 3)
            {
                Console.WriteLine(player2.name + " wins!");
            }

        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            playAgain = (Console.ReadLine());
            if (playAgain == "yes")
            {
                RunGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
        public void CompareGestures()
        {
            if (player1.gesture == player1.ListOfGestures[0] && player2.gesture == player2.ListOfGestures[2] || player2.gesture == player2.ListOfGestures[3])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player1.gesture == player1.ListOfGestures[1] && player2.gesture == player2.ListOfGestures[0] || player2.gesture == player2.ListOfGestures[4])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player1.gesture == player1.ListOfGestures[2] && player2.gesture == player2.ListOfGestures[1] || player2.gesture == player2.ListOfGestures[3])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player1.gesture == player1.ListOfGestures[3] && player2.gesture == player2.ListOfGestures[4] || player2.gesture == player2.ListOfGestures[1])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player1.gesture == player1.ListOfGestures[4] && player2.gesture == player2.ListOfGestures[0] || player2.gesture == player2.ListOfGestures[2])
            {
                player1.PlayerScoredPoints();
                Console.WriteLine(player1.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player2.gesture == player2.ListOfGestures[0] && player1.gesture == player1.ListOfGestures[2] || player1.gesture == player1.ListOfGestures[3])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player2.gesture == player2.ListOfGestures[1] && player1.gesture == player1.ListOfGestures[0] || player1.gesture == player1.ListOfGestures[4])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player2.gesture == player2.ListOfGestures[2] && player1.gesture == player1.ListOfGestures[1] || player1.gesture == player1.ListOfGestures[3])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player2.gesture == player2.ListOfGestures[3] && player1.gesture == player1.ListOfGestures[4] || player1.gesture == player1.ListOfGestures[1])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player2.gesture == player2.ListOfGestures[4] && player1.gesture == player1.ListOfGestures[0] || player1.gesture == player1.ListOfGestures[2])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
                return;
            }
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("You tied! Move on to next round.");
                Console.ReadLine();
                return;
            }
        }
    }
        
        
    }
        

