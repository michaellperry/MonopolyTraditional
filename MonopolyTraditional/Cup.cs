using System.Collections.Generic;
using System.Linq;

namespace MonopolyTraditional
{
    public class Cup
    {
        public List<Die> Dice { get; }

        public Cup()
        {
            Dice = new List<Die>
            {
                new Die(new RandomSequence()),
                new Die(new RandomSequence())
            };
        }

        public Cup(IEnumerable<Die> dice)
        {
            Dice = dice.ToList();
        }

        public void Roll()
        {
            Dice.ForEach(d => d.Roll());
        }

        public int Total => Dice.Sum(d => d.Face);
        public bool Doubles => Dice.Select(d => d.Face).Distinct().Count() == 1;
    }
}
