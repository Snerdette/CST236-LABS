using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerLibrary;

namespace PokerLibraryUnitTests
{
    [TestClass]
    public class FiveCardDrawPokerRulesUT
    {

        private class TestDeck : IDeck
        {
            public int Count { get { return 5; } }

            public ICard[] Deal(int count)
            {
                return new ICard[5]
                {
                 new PokerCard(CardSuit.Club, CardFace.Two),
                 new PokerCard(CardSuit.Club, CardFace.Three),
                 new PokerCard(CardSuit.Club, CardFace.Four),
                 new PokerCard(CardSuit.Club, CardFace.Five),
                 new PokerCard(CardSuit.Club, CardFace.Six)
                };
            }

            public void Shuffle()
            {
                throw new NotImplementedException();
            }
        }


        [TestMethod]
        public void TestDeal()
        {
            // DealHand should return a pokerHand Instance with the first 5 cards from the deck;
            IPokerRules pr = new FiveCardDrawPokerRules();
            IHand h = pr.DealHand(new TestDeck());
            Assert.AreEqual(h.Count, 5); // 5 because it;s 5-card draw!
            Assert.IsInstanceOfType(h, typeof(PokerHand));
            int i = 2;
            foreach (ICard c in h)
            {
                Assert.AreEqual(c.Suit, CardSuit.Club);
                Assert.AreEqual(c.Face, i);
                i++;
            }
            Assert.AreEqual(i, 7); // The last card shoild be a 6
        }

        [TestMethod]
        public void TestCompareHand()
        {
            // DealHand should return a pokerHand Instance with the first 5 cards from the deck;
            IPokerRules pr = new FiveCardDrawPokerRules();
            IHand h = pr.DealHand(new TestDeck());
            Assert.AreEqual(h.Count, 5); // 5 because it;s 5-card draw!
            Assert.IsInstanceOfType(h, typeof(PokerHand));
            int i = 2;
            foreach (ICard c in h)
            {
                Assert.AreEqual(c.Suit, CardSuit.Club);
                Assert.AreEqual(c.Face, i);
                i++;
            }
            Assert.AreEqual(i, 7); // The last card shoild be a 6
        }

        [TestMethod]
        public void TestRankHand()
        {
            // Test an example of each of the 9 ranks we expcect for this game
            // Noting that rank 0 is not possible in this game (because the Joker is dead! R.I.P Heath Ledger!
            IPokerRules pr = new FiveCardDrawPokerRules();
            //Assert.AreEqual(1, pr.RankHand());
        }
    }
    
}
