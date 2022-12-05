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
            switch (die)
            {
                case 0:
                    place += position;
                    Console.WriteLine("The player climbed the ladder");
                    break;
                case 1:
                    place -= die;
                    if (place < 0)
                    {
                        Console.WriteLine("The player bit by snake");
                        place = 0;
                    }
                    else
                    {
                        Console.WriteLine("The player bit by snake");
                    }
                    break;
                default:
                    Console.WriteLine("No play");
                    break;

            }
            Console.WriteLine("The position of player1 is " + place);
        }
    }
}

