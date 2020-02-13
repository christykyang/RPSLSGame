﻿using System;
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
        public string readyToPlay;
        public string numberOfPlayers;
        public string rulesList;
        //constructors
        public PlayGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard, Spock!");
            Console.ReadLine();
            Console.WriteLine("Do you need the list of rules?");
            DisplayRules();
        }
        //member methods
        public void DisplayRules()
        {
            rulesList = (Console.ReadLine());
            switch (rulesList)
            {
                case "yes":
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
                    Console.WriteLine("Best of three wins!");
                    ReadyToPlay();
                    break;
                case "no":
                    ReadyToPlay();
                    break;
                default:
                    Console.WriteLine("Please choose yes or no. Do you need the list of rules?");
                    DisplayRules();
                    break;
            }
        }
        public void ReadyToPlay()
        {
            Console.WriteLine("Are you ready to play?");
            readyToPlay = (Console.ReadLine());
            switch (readyToPlay)
            {
                case "yes":
                    Console.WriteLine("Let's play!");
                    RunGame();
                    break;
                case "no":
                    EndGame();
                    break;
                default:
                    Console.WriteLine("Please choose yes or no.");
                    ReadyToPlay();
                    break;

            }
        }
        public void RunGame()
        {
            
            GameBasedOnPlayerNumber();
            while (player1.score <= 2 && player2.score <= 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
            DisplayWinner();
            PlayAgain();
        }
        public void EndGame()
        {
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
        public void GetPlayerNumber(string numberOfPlayers)
        {
            Console.WriteLine("How many players did you want playing?");
            this.numberOfPlayers = (Console.ReadLine());
            switch (this.numberOfPlayers)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Not a vaild option. Please try again.");
                    GetPlayerNumber(numberOfPlayers);
                    break;
            }
        }
        public void GameBasedOnPlayerNumber()
        {
            GetPlayerNumber(numberOfPlayers);
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
        }
        public void DisplayWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine(player1.name + " wins game!");
            }
            else 
            {
                Console.WriteLine(player2.name + " wins game!");
            }

        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            playAgain = (Console.ReadLine());
            if (playAgain == "yes")
            {
                ReadyToPlay();
            }
            else
            {
                EndGame();
            }
        }
        public void CompareGestures()
        {
            if (player1.gesture == player1.ListOfGestures[0] && player2.gesture == player2.ListOfGestures[2] || player2.gesture == player2.ListOfGestures[3])
            {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " crushes " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
            }
            else if (player1.gesture == player1.ListOfGestures[1] && player2.gesture == player2.ListOfGestures[0] || player2.gesture == player2.ListOfGestures[4])
            {
                if(player2.gesture == player2.ListOfGestures[0])
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " covers " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " disproves " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
            }
            else if (player1.gesture == player1.ListOfGestures[2] && player2.gesture == player2.ListOfGestures[1] || player2.gesture == player2.ListOfGestures[3])
            {
                if (player2.gesture == player2.ListOfGestures[1])
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " cuts " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " decapitates " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                
            }
            else if (player1.gesture == player1.ListOfGestures[3] && player2.gesture == player2.ListOfGestures[4] || player2.gesture == player2.ListOfGestures[1])
            {
                if (player2.gesture == player2.ListOfGestures[4])
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " poisons " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " eats " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
            }
            else if (player1.gesture == player1.ListOfGestures[4] && player2.gesture == player2.ListOfGestures[0] || player2.gesture == player2.ListOfGestures[2])
            {
                if (player2.gesture == player2.ListOfGestures[2])
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " smashes " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player1.gesture + " vaporizes " + player2.gesture);
                    Console.WriteLine(player1.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
            }
            else if (player2.gesture == player2.ListOfGestures[0] && player1.gesture == player1.ListOfGestures[2] || player1.gesture == player1.ListOfGestures[3])
            {
                player2.PlayerScoredPoints();
                Console.WriteLine(player2.gesture + " crushes " + player1.gesture);
                Console.WriteLine(player2.name + " wins round!");
                Console.ReadLine();
            }
            else if (player2.gesture == player2.ListOfGestures[1] && player1.gesture == player1.ListOfGestures[0] || player1.gesture == player1.ListOfGestures[4])
            {
                if (player1.gesture == player1.ListOfGestures[0])
                {
                    player2.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " covers " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player2.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " disproves " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
            }
            else if (player2.gesture == player2.ListOfGestures[2] && player1.gesture == player1.ListOfGestures[1] || player1.gesture == player1.ListOfGestures[3])
            {
                if (player1.gesture == player1.ListOfGestures[1])
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " cuts " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player2.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " decapitates " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
            }
            else if (player2.gesture == player2.ListOfGestures[3] && player1.gesture == player1.ListOfGestures[4] || player1.gesture == player1.ListOfGestures[1])
            {
                if (player1.gesture == player1.ListOfGestures[4])
                {
                    player2.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " poisons " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player2.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " eats " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
            }
            else if (player2.gesture == player2.ListOfGestures[4] && player1.gesture == player1.ListOfGestures[0] || player1.gesture == player1.ListOfGestures[2])
            {
                if (player1.gesture == player1.ListOfGestures[2])
                {
                    player2.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " smashes " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    player1.PlayerScoredPoints();
                    Console.WriteLine(player2.gesture + " vaporizes " + player1.gesture);
                    Console.WriteLine(player2.name + " wins round!");
                    Console.ReadLine();
                    return;
                }
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
        

