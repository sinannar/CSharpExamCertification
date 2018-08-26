﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLab.Chapter2.Objective1
{
    public static class Listing_2_10
    {
        public static void RunMain()
        {
            var cardCollection = new List<Card>();
            for (int i = 0; i < 10; i++)
            {
                cardCollection.Add(new Card() { Number = i });
            }

            Deck deck = new Deck(cardCollection);
            var firstCard = deck[0];
            Console.WriteLine("First card's number in the Deck object is: {0}", firstCard.Number);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        class Card
        {
            public int Number { get; set; }
        }

        class Deck
        {
            public Deck(ICollection<Card> cards)
            {
                this.Cards = cards;
            }

            public ICollection<Card> Cards { get; private set; }

            public Card this[int index]
            {
                get { return Cards.ElementAt(index); }
            }
        }
    }
}
