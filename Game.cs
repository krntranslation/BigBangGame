using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public class Game
    {
        //member Variables

        string rules;
        int roundScore;
        int winGame;
        string title;
        string MessageBox;
        int players;
        int score;
        
        

        Player player1 = new Human();
        Player player2;
        //constructor

        public Game()
        {
            roundScore = 0;
            winGame = 2;
            rules = " Welcome to Paper, Rock, Scissor, Lizard, and Spock game. \n This game is the best of three. \n Game will only have two players. \n Either Player 1 vs Player 2 or Player 1 vs CPU";
            title = "GameRules";
            players = 0;
            score = 0;
            int rock = 0;
            int paper = 1;
            int scissor = 2;
            int lizard = 3;
            int spock = 4;

        }

        //member methods
        public void RunGame()
        {
            Console.WriteLine(rules);
            rules = Console.ReadLine();

            numberOfPlayers();
            //CreatePlayers();
            //RoundStart();
            player1.ChooseHandGesture();
            player2.ChooseHandGesture();
            Console.WriteLine("Player1 Gesture: " + player1.gesture + "\nPlayer2 Gesture: " + player2.gesture);
            Console.ReadLine();
            CompareResults();
            RoundScore();


        }
        public void numberOfPlayers()
        {
            Console.WriteLine("How many players?");
            players = int.Parse(Console.ReadLine());

            if (players == 1)
            {
                Console.WriteLine("Please enter in your name");
                player1.name = Console.ReadLine();
                Console.WriteLine(player1.name + " vs Cpu");
                CreatePlayers();
            }
            else if (players == 2)
            {
                Console.WriteLine("Please enter in your name");
                player1.name = Console.ReadLine();
                CreatePlayers();
                
            }
            else
            {
                RunGame();
            }

        }
        public void CreatePlayers()
        {
            if (players == 1)
            {
                player2 = new Computer();
                player2.name = "Computer";
            }
            else if(players == 2)
            {
                player2 = new Human();
                Console.WriteLine("Please enter your name");
                player2.name = Console.ReadLine();
                Console.WriteLine(player1.name + " vs " + player2.name);
               
            }

        
        }

        
        public void CompareResults()
        {

            //(5 + player1.gesture - player2.gesture) % 5 = x;
            //if (x = 1 || x = 3) ;
            //player1.name = player1.score + 1;
            //    else if (x = 2 || x = 4) ;
            //player2.name = player1.score + 1;



        }
        public void RoundScore()
         {
            for (winGame = 0; winGame > 3; winGame++)
                Console.WriteLine();
            {
                
            }


                

                    
         }


    }       
        
}
