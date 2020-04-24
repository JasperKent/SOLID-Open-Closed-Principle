using System;

namespace RockPaperScissors.Strategy
{
    public interface IRPSStrategy
    {
        protected readonly static Random _random = new Random();

        Sign Throw();
    }
}
