using System;

namespace MonopolyTraditional
{
    public class Die
    {
        public int Face { get; private set; }
        private ISequence sequence;

        public Die(ISequence sequence)
        {
            this.sequence = sequence;
            Face = this.sequence.Next();
        }

        public void Roll()
        {
            Face = this.sequence.Next();
        }
    }
}
