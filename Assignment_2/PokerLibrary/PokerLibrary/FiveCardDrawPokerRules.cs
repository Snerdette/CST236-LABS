using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class FiveCardDrawPokerRules : IPokerRules
    {
        public int Compare(IHand h1, IHand h2)
        {
            throw new NotImplementedException();
        }

        public IHand DealHand(IDeck d)
        {
            // Assume deck is already shuffled
            // Get 5 cards frin the deck and add them to a new PokerHand.
            return new PokerHand(d.Deal(5));
        }

        public string NameHand(IHand h)
        {
            throw new NotImplementedException();
        }

        // Rank 1 - 9, 0 is not possible
        public int RankHand(IHand h)
        {
            // given a hadn of cards, copy into an array
            // Use available pattern methods tp determin the rank by calling in sequence from high to low
            if (SameSuit(h) && InSequence(h)) // Straight Flush
                return 1;
            if (SameSuit(h))    // Flush
                return 4;
            if (InSequence(h))  // Straight
                return 5;

            return 9;
        }

        public bool SameSuit(IHand h)
        {
            // Get the first cards suit
            CardSuit s = h.First().Suit;

            // Check all cards against the expected suit
            foreach (ICard card in h)
            {
                if (card.Suit != s)
                {
                    return false;
                }
            }

            return true;
        }

        public bool InSequence(IHand h)
        {
            // Copy the list and sort it by face 
            List<ICard> sorted = new List<ICard>(h.OrderBy<ICard, CardFace>(c => { return c.Face;  }));

            // For each card determine if it is the next face value from the previous card.
            CardFace previous = sorted[0].Face;
            for (int i = 1; i < sorted.Count; i++)
            {
                if ((CardFace)(previous + 1) != sorted[i].Face)
                    return false;

                previous = sorted[i].Face;
            }
            return true;
        }
    }
}
