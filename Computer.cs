using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    public class Computer : Player
    {

        public override void ChooseHandGesture()
        {
            var random = new Random();
            var list = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            int index = random.Next(list.Count);
            gesture = list[index];
            Console.ReadLine();
        }


    }

}
