using System;

namespace Chopsticks
{
    class Program
    {
        static void Main(string[] args)
        {
            ChopSticks game = new ChopSticks(2);
            Console.WriteLine(game.GetInfo());
        }
    }
}
