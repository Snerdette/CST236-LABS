using System;

namespace PokerLibrary
{
    public interface IDeck
    {
        int Count { get; }
        void Shuffle();
        ICard[] Deal(int count);
    }
}
