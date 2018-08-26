using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_11
    {
        public static void RunMain()
        {
            Deck deck = new Deck(5);
        }

        class Card
        {
            public int Number { get; set; }
        }

        class Deck
        {
            private int maximumNumberOfCards;

            public List<Card> Cards { get; set; }

            public Deck(int maximumNumberOfCards)
            {
                this.maximumNumberOfCards = maximumNumberOfCards;
                Cards = new List<Card>();
            }
        }
    }
}
