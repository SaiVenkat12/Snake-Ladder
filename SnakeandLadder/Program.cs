using System;
namespace SnakeandLadder
{
    internal class program
    {
        static void Main(string[] args)
        {
            int start = 0;
            Console.WriteLine("Snake and Ladder Game");
            var random = new Random();
            int position = random.Next(1, 7);
            Console.WriteLine("Player 1 position is "+position );


        }
    }
}