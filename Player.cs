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
        public double gesture;
        public int player1Score;
        public int player2Score;
        
        

        //constructor
        

        public Player()
        {
            name = null;
            gesture = 0;
           
        }

        

        public abstract void ChooseHandGesture();











    }
}
