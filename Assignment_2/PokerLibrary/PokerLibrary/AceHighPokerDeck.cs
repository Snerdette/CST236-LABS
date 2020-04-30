using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class AceHighPokerDeck : IDeck
    {
        public AceHighPokerDeck(ICard[] cards, Random random)
        {

        }



        public int Count => throw new NotImplementedException();

        public ICard[] Deal(int count)
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
