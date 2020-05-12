using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerLibrary;

namespace PokerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two Simple Demos for Assignment 2
            Random rand = new Random();

            // 1. Deal one hand, print the rank and names of the hand.
            FiveCardDrawPokerRules pr = new FiveCardDrawPokerRules();
            AceHighPokerDeck deck = new AceHighPokerDeck(rand);
            deck.Shuffle();
            IHand h1 = pr.DealHand(deck);
            Console.WriteLine("Demo 1...");
            Console.WriteLine("Rank = " + pr.RankHand(h1));
            //Console.WriteLine("Name = " + pr.NameHand(h1));
            // 2. Deal two hands print the rank and names of the hands, compare and print who wins. 
        }
    }
}
