using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public class Human : Player
    {
       
        
        public override void ChooseHandGesture()
        {
            Console.WriteLine("Type in your hand gesture");
            gesture = Console.ReadLine();
        }
    }
}