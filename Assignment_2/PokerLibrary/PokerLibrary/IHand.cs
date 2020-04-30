using System;
using System.Collections.Generic;

namespace PokerLibrary
{
    public interface IHand : IEnumerable<ICard>
    {
        void Add(ICard c);
        void Remove(ICard c);
    }
}
