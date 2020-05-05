using System;

namespace PokerLibrary
{
    public enum CardSuit
    {
        Club,
        Heart,
        Diamond,
        Spade
    }

    public enum CardFace
    {
        AceLow = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        AceHigh = 14

    }
    
    public interface ICard
    {
        CardSuit Suit { get; }
        CardFace Face { get; }
    }
}
