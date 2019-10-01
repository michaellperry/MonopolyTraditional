using System;

namespace MonopolyTraditional
{
    public class RandomSequence : ISequence
    {
        private Random random = new Random();

        public int Next()
        {
            return random.Next(6) + 1;
        }
    }
}
