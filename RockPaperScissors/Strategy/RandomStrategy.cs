namespace RockPaperScissors.Strategy
{
    public class RandomStrategy : IRPSStrategy
    {
        public Sign Throw()
        {
            return (Sign)IRPSStrategy._random.Next(3);
        }
    }
}
