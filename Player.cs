using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public abstract class Player
    {
        //member Variables

        public string name;
        public string gesture;
        public int player1Score;
        public int player2Score;
        

        //constructor
        

        public Player()
        {
            name = null;
            gesture = null;
            player1Score = 0;
            player2Score = 0;
            
        }

        //member methods

        //public void playerName(string name)
        //{
        //    //this.name = name;
        //    //Console.WriteLine(name);
        //}
        //public void playerScore()
        //{
        //    //for (i = 0; i <= 3; i++;);
        //    //Console.WriteLine("Value of i", i);
        //}
        //public void playerGesture()
        //{
        //    Console.WriteLine("Type in a gesture");
        //    gesture = Console.ReadLine();
        //}

        public abstract void ChooseHandGesture();











    }
}
