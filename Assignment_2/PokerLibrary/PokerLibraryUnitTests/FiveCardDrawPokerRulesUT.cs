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
                Assert.AreEqual(c.Face, (CardFace)i);
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
            //structure of this test case is...
            // create a collection of hands w/ expected rannk
            // loop through collection, cal RankHand() and compare actual vs expected
            // fail the test when the first expected is NOT equal to the actual result
            
            IPokerRules pr = new FiveCardDrawPokerRules();
            List<RankTestHand> testCases = CreateRankTestHands();
            foreach (RankTestHand h in testCases)
            {
                Assert.AreEqual(h.rank, pr.RankHand(h.hand));
            }
        }

        private class RankTestHand
        {
            public IHand hand;
            public int rank;

            public RankTestHand(IHand h, int r)
            {
                hand = h;
                rank = r;
            }
        }

        private List<RankTestHand> CreateRankTestHands()
        {
            List<RankTestHand> result = new List<RankTestHand>();

            result.Add(new RankTestHand(CreateHand("5S 6S 4S 8S 7S"), 1));
            result.Add(new RankTestHand(CreateHand("5D 6C 4H 8S 7D"), 5));
            result.Add(new RankTestHand(CreateHand("4S 6S 8S JS AS"), 4));
            result.Add(new RankTestHand(CreateHand("4D 6C 8H JS AD"), 9));

            return result;
        }

        private IHand CreateHand(string s)
        {
            PokerHand hand = new PokerHand();
            string[] cards = s.Split( ' ');
            foreach (string card in cards)
            {
                CardSuit suit = CardSuit.Club;
                switch (card[1])
                {
                    case 'C': suit = CardSuit.Club; break;
                    case 'D': suit = CardSuit.Diamond; break;
                    case 'S': suit = CardSuit.Spade; break;
                    case 'H': suit = CardSuit.Heart; break;
                }
                CardFace face = CardFace.AceHigh;
                switch (card[0])
                {
                    case 'J': face = CardFace.Jack; break;
                    case 'Q': face = CardFace.Queen; break;
                    case 'K': face = CardFace.King; break;
                    case 'A': face = CardFace.AceHigh; break;
                    default:
                        {
                            string faceString = card.Substring(0, 1);
                            int faceInt = int.Parse(faceString);
                            face = (CardFace)faceInt; 
                        }
                        break;
                }

                hand.Add(new PokerCard(suit, face));
            }
            return hand;
        }
    }
    
}
