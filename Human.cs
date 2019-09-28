using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public class Human : Player
    {
       
        public Human()
        {
            gesture = null;
           
            //hold the imput for player 1 if there is a player 2 
        }

        public override void ChooseHandGesture()
        {
            Console.WriteLine("Enter in hand gesture");
            gesture = Console.ReadLine();
        }
    }
}