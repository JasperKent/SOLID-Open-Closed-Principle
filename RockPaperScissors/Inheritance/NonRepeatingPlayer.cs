namespace RockPaperScissors.Inheritance
{
    public class NonRepeatingPlayer : Player
    {
        public NonRepeatingPlayer(string name)
            :base(name)
        {
        }

        private Sign? _lastSign;

        public override void Throw()
        {
            if (_lastSign == null)
            {
                base.Throw();

                _lastSign = Sign;
            }
            else
            {
                var sign = (Sign)_random.Next(2);

                if (sign == _lastSign)
                    sign = (Sign)2;

                _lastSign = Sign = sign;
            }
        }
    }
}
