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
        int rock = 0;
        int paper = 1;
        int scissor = 2;
        int lizard = 3;
        int spock = 4;
        public string gesture;
        public HandGestures()
        {
            gesture = null;
        }

        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        List<string> gestures2 = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        //public void startGesture()
        //{
        //    Console.WriteLine("Player 1 type in your gesture");
        //    input1.gesture = Console.ReadLine();
        //    Console.WriteLine("Player 2 type in your gesture");
        //    input2.gesture = Console.ReadLine();

        //    if (input1.gesture == input2.gesture)
        //    {
        //        startGesture();
        //    }
        //    //else if (input1.gesture != input2.gesture)
            
        //    //    if (5 + (a - b) % 5) = d;
        //    //    d = 1 || d = 3 >=;
        //    //    return Player a wins 

        //    //    d = 2 || d= 4 >= b wins

        //    //}

        //    else
        //    {
        //        startGesture();
        //    }


        //}
 


    }



}
    
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

