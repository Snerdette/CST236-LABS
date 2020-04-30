using System;

namespace PokerLibrary
{
    public interface IPokerRules
    {
        IHand DealHand(IDeck d);
        int Compare(IHand h1, IHand h2); // h1 < h2 ==> -1; h1 == h2 ==> 0; h1 > h2 ==> 1;
        int RankHand(IHand h); // Rank 0 - 9 (per Wikipedia rules)
        string NameHand(IHand h); // Name of hand (per Wikipedia naming convention)

    }
}
