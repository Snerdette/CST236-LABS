using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class PokerCard : ICard
    {
        private CardSuit suit;
        private CardFace face;

        public PokerCard(CardSuit s, CardFace f)
        {
            suit = s;
            face = f;
        }

        public CardSuit Suit { get { return suit; } }
        public CardFace Face { get { return face; } }

        public override bool Equals(object obj)
        {
            return (obj is ICard) && (suit == (obj as ICard).Suit) && (face == (obj as ICard).Face);
        }
    }
}
