using System;

namespace RockPaperScissors.Inheritance
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; set; }
        public Sign Sign { get; protected set; }

        public Player(string name)=>Name = name;

        protected readonly static Random _random = new Random();

        public virtual void Throw()
        {
            Sign = (Sign)_random.Next(3);
        }
    }
}
