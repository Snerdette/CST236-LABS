using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class AceHighPokerDeck : IDeck
    {
        private Random rand;
        private List<PokerCard> cards;

        public AceHighPokerDeck(Random rand)
        {
            this.rand = rand;
            // Fill stack initially with 52 cards where Aces are high.
            cards = new List<PokerCard>();

            for (CardSuit s = CardSuit.Club; s <= CardSuit.Spade; s++)
            {
                for (CardFace f = CardFace.Two; f <= CardFace.AceHigh; f++)
                {
                    cards.Add(new PokerCard(s, f));
                }
            }
        }

        // Both the same:
        //public int Count => cards.Count;
        public int Count { get { return cards.Count; } }

        public ICard[] Deal(int count)
        {
            // Check if there are engough cards in the deck
            if (cards.Count < count)
                throw new Exception("Not Enough Cards in the Deck!");

            // Remove cards from the deck and
            // Return an array with the top "count" cards
            ICard[] hand = cards.GetRange(0, count).ToArray();
            cards.RemoveRange(0, count);
            
            return hand;
        }

        public void Shuffle()
        {
            // Randomly reorder the cards currently in the deck
            // TODO: AceHighPokerDEck.Shuffle()
            List<PokerCard> shuffled = new List<PokerCard>();
            while (cards.Count > 0)
            {
                int at = rand.Next(cards.Count);
                shuffled.Add(cards[at]);
                cards.RemoveAt(at);
            }
            cards = shuffled;
        }
    }
}
