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
        string whosplaying;

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
            whosplaying = null;
        }

        //member methods
        public void RunGame()
        {
            Console.WriteLine(rules);
            rules = Console.ReadLine();

            numberOfPlayers();
            CreatePlayers();
            ////startGame();
            player1.ChooseHandGesture();
            player2.ChooseHandGesture();
            Console.WriteLine("Player1 Gesture: " + player1.gesture + "\nPlayer2 Gesture: " + player2.gesture);
            Console.ReadLine();
            




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
                Console.WriteLine("Please enter in name");
                player2.name = Console.ReadLine();
            }

        
        }

        public void numberOfPlayers()
        {
            Console.WriteLine("How many players?");
            players = int.Parse(Console.ReadLine());

            if (players == 1)
            {
                Console.WriteLine("Whats your name?");
                player1.name = Console.ReadLine();
                Console.WriteLine("player1 vs Cpu");
            }
            else if (players == 2)
            {
                Console.WriteLine("Whats your name?");
                player1.name = Console.ReadLine();
            }
            else
            {
                RunGame();
            }
        }
        


    }       
        
}
