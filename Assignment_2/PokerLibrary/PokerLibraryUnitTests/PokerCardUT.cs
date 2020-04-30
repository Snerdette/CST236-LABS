using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerLibrary;

namespace PokerLibraryUnitTests
{
    [TestClass]
    public class PokerCardUT
    {
        [TestMethod]
        public void TestConstructor()
        {
            // Make sure we get back thesame suit/face that we put in
            // Assume that if we can put in one combo then it will work for others.
            ICard c = new PokerCard(CardSuit.Club, CardFace.AceHigh);
            Assert.AreEqual(CardSuit.Club, c.Suit);
            Assert.AreEqual(CardFace.AceHigh, c.Face);
        }

        [TestMethod]
        public void TestEquals()
        {
            // Ensure that we can evaluate if two poker cards are equal by value or not.
            ICard c1 = new PokerCard(CardSuit.Club, CardFace.AceHigh);
            ICard c2 = new PokerCard(CardSuit.Club, CardFace.AceHigh);
            ICard c3 = new PokerCard(CardSuit.Heart, CardFace.Nine);

            Assert.AreEqual(c1, c2);
            Assert.AreNotEqual(c1, c3);
            Assert.AreNotEqual(c2, c3);

        }
    }
}
