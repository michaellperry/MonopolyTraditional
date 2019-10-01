using System;
using System.Collections.Generic;

namespace MonopolyTraditional
{
    public class FixedSequence : ISequence
    {
        private IEnumerator<int> enumerator;

        public FixedSequence(IEnumerable<int> values)
        {
            this.enumerator = values.GetEnumerator();
        }

        public int Next()
        {
            if (enumerator.MoveNext())
            {
                return enumerator.Current;
            }
            else
            {
                throw new InvalidOperationException("Moved past the end of the sequence.");
            }
        }
    }
}
