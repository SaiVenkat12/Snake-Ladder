using Microsoft.VisualBasic.FileIO;
using System;
using System.Xml.Linq;

namespace SnakeandLadder
{
    public class program
    {
        public const int ladder = 0;
        public const int a = 1;
        static void Main(string[] args)
        {
            int place = 0;
            Console.WriteLine("Snake and Ladder Game");
            var random = new Random();
            int position = random.Next(1, 7);
            var rand = new Random();
            int die = rand.Next(0, 3);
            while(place<=100)
            {
                switch (die)
                {
                    case 0:
                        place += position;
                        
                        break;
                    case 1:
                        place -= die;
                        if (place < 0)
                        {
                            
                            place = 0;
                        }
                        break;
                    default:
                        place= place;
                        break;

                }
            }
            Console.WriteLine("The position of player1 is " + place);
        }
    }
}

