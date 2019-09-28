using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBangGame
{
    class HandGestures
    {
        HandGestures input1 = new HandGestures();
        HandGestures input2 = new HandGestures();

        public string gesture;
        public HandGestures()
        {
            gesture = null;
        }
        
        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };


        public void startGesture()
        {
            Console.WriteLine("Pick your gesture");
            input1.gesture = Console.ReadLine();
            Console.WriteLine("Pick your gesture");
            input2.gesture = Console.ReadLine();
            
            if(input1.gesture == input2.gesture)
            {
                startGesture();
            }
            else if (input1.gesture != input2.gesture)
            {
                compareResults();
            }

            else
            {
                startGesture();
            }  

            
        }
        public void compareResults()
        {
           
        }



    }

    

}
    
    //{
    //    string rock;
    //    string paper;
    //    string scissors;
    //    string lizard;
    //    string spock;
    //    string hand;



    //    private class gestures
    //    {
    //        gestures = new List<string>(4){ "rock", "paper", "scissor", "lizard", "spock" };

    //    }
       
    //    public static void handGestures()
    //    {
            
    //    }

        
        
        
    //}

