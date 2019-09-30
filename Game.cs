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
        int handgesture1;
        int handgesture2;
        int x;
        int player1Score;
        int player2Score;

        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };



        Player player1 = new Human();
        Player player2;
        //constructor

        public Game()
        {
            roundScore = 0;
            winGame = 2;
            rules = " Welcome to Paper, Rock, Scissor, Lizard, and Spock game. \n Please enter a number 0 -4 for gestures. \n rock = 0 \n paper = 1 \n scissor = 2 \n lizard = 3 \n spock = 4 \n This game is the best of three. \n Game will only have two players. \n Either Player 1 vs Player 2 or Player 1 vs CPU \n press enter to start";
            title = "GameRules";
            players = 0;
            score = 0;
            x = 0;
            player1Score = 0;
            player2Score = 0;
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
            //Console.WriteLine("Player1 Gesture: " + player1.gesture + "\nPlayer2 Gesture: " + player2.gesture);
            //Console.ReadLine();
            CompareResults();
            //RoundScore();


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
            else if (players == 2)
            {
                player2 = new Human();
                Console.WriteLine("Please enter your name");
                player2.name = Console.ReadLine();
                Console.WriteLine(player1.name + " vs " + player2.name);

            }

        }
        public void CompareResults()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Its a tie, try again.");
                player1.ChooseHandGesture();
                player2.ChooseHandGesture();
            }
            else if (player1.gesture == 0 && player2.gesture == 1)
            {
                Console.WriteLine("Player 2 wins round"); 
                player2Score++;
                RoundScore(); 
            }
            else if (player1.gesture == 0 && player2.gesture == 2)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 0 && player2.gesture == 3)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 0 && player2.gesture == 4)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 1 && player2.gesture == 0)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 1 && player2.gesture == 2)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 1 && player2.gesture == 3)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 1 && player2.gesture == 4)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 2 && player2.gesture == 0)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 2 && player2.gesture == 1)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 2 && player2.gesture == 3)
            {
                Console.WriteLine("Player 1 wins round");  
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 2 && player2.gesture == 4)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 3 && player2.gesture == 0)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++; 
                RoundScore();
            }
            else if (player1.gesture == 3 && player2.gesture == 1)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 3 && player2.gesture == 2)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 3 && player2.gesture == 4)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 4 && player2.gesture == 0)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 4 && player2.gesture == 1)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
            else if (player1.gesture == 4 && player2.gesture == 2)
            {
                Console.WriteLine("Player 1 wins round");
                player1Score++;
                RoundScore();
            }
            else if (player1.gesture == 4 && player2.gesture == 3)
            {
                Console.WriteLine("Player 2 wins round");
                player2Score++;
                RoundScore();
            }
        }
       
        public void RoundScore()
        {
            if (player1Score == 2)
            {
                Console.WriteLine("Player 1 Wins Game!");
                Console.ReadLine();
            }
            else if (player2Score == 2)
            { 
                Console.WriteLine("Player 2 Wins Game!");
                Console.ReadLine();
            }
            else if(player1Score == 1 || player2Score == 1)
            {
                player1.ChooseHandGesture();
                player2.ChooseHandGesture();
                CompareResults();

            }
   

        }

    }
}
//   ((5 + player1.gesture) - player2.gesture) % 5 == x)

//    {
//        if (x == 1 || x == 3)
//        {
//            Console.WriteLine("Player 1 wins this round");
//            Console.ReadLine();

//        }
//        if (x == 2 || x == 4)
//        {

//            Console.WriteLine(" Player 2 wins this round");
//            Console.ReadLine();

//        }
//        if(x == 0)
//        {
//            player1.ChooseHandGesture();
//            player2.ChooseHandGesture();


//        }
//    }
//    else
//    {
//        player1.ChooseHandGesture();
//        player2.ChooseHandGesture();
//    }    

//}









