using System;
using RockPaperScissors.Strategy;
//using RockPaperScissors.Inheritance;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many throws? ");

            int count = int.Parse(Console.ReadLine());

//            Game game = new Game(new Player("Sally"), new NonRepeatingPlayer("Harry"));
            Game game = new Game(new Player("Sally", new RandomStrategy()), new Player("Harry", new NonRepeatingStrategy()));

            for (int i = 0; i < count; ++i)
                game.Iterate();
        }
    }
}
