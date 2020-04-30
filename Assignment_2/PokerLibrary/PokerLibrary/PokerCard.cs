using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class PokerCard : ICard
    {

        public PokerCard(CardSuit suit, CardFace face)
        {

        }

        public CardSuit Suit => throw new NotImplementedException();

        public CardFace Face => throw new NotImplementedException();

        //public static bool operator==(PokerCard c1, PokerCard c2)
        //{
        //    throw new NotImplementedException();
        //}

        //public static bool operator !=(PokerCard c1, PokerCard c2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
