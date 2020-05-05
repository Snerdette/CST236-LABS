using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class PokerHand : IHand
    {
        private List<ICard> cards;

        public PokerHand()
        {
            // Empty hand
            cards = new List<ICard>();

        }

        public PokerHand(ICard[] initialCards)
        {
            // hand with initial cards
            cards = new List<ICard>(initialCards);
        }

        public int Count { get { return cards.Count; } }
        public void Add(ICard c)
        {
            cards.Add(c);
        }

        public void Remove(ICard c)
        {
            cards.Remove(c);
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cards.GetEnumerator();
        }
        
    }
}
