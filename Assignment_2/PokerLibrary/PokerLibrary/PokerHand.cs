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
        public int Count => throw new NotImplementedException();

        public PokerHand()
        {

        }

        public PokerHand(ICard[] cards)
        {

        }

        public void Add(ICard c)
        {
            throw new NotImplementedException();
        }

        public void Remove(ICard c)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
    }
}
