using System;
using System.Collections.Generic;
using DeckOfCards.CardClass;

namespace DeckOfCards.DeckClass
{
    class Deck
    {
        List<Card> deck = new List<Card> ();

        IDictionary<int, string> cardValues = new Dictionary<int, string> () { { 0, "Ace" }, { 1, "Two" }, { 2, "Three" }, { 3, "Four" }, { 4, "Five" }, { 5, "Six" }, { 6, "Seven" }, { 7, "Eight" }, { 8, "Nine" }, { 9, "Ten" }, { 10, "Jack" }, { 11, "Queen" }, { 12, "King" } };

        IDictionary<int, string> suitValues = new Dictionary<int, string> () { { 0, "Clubs" }, { 1, "Spades" }, { 2, "Hearts" }, { 3, "Diamonds" } };

        public Deck ()
        {
            for (int i = 0; i < 13; i++)
            {
                deck.Add (new Card (cardValues[0], suitValues[0], i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                deck.Add (new Card (cardValues[1], suitValues[1], i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                deck.Add (new Card (cardValues[2], suitValues[2], i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                deck.Add (new Card (cardValues[3], suitValues[3], i + 1));
            }
        }
        public Card DealCard ()
        {
            Random rand = new Random ();
            int randInt = rand.Next (0, deck.Count);
            Card newCard = deck[randInt];
            deck.RemoveAt (randInt);

            return newCard;
        }

        public List<Card> Reset (List<Card> deck)
        {
            for (int i = 0; i < 13; i++)
            {
                deck[i] = new Card (cardValues[0], suitValues[0], i + 1);
            }
            for (int i = 13; i < 26; i++)
            {
                deck[i] = new Card (cardValues[1], suitValues[1], i + 1);
            }
            for (int i = 26; i < 39; i++)
            {
                deck[i] = new Card (cardValues[2], suitValues[2], i + 1);
            }
            for (int i = 39; i < 52; i++)
            {
                deck[i] = new Card (cardValues[3], suitValues[3], i + 1);
            }

            return deck;
        }

        public List<Card> Shuffle (List<Card> deck)
        {
            Random rand = new Random ();

            for (int i = 0; i < deck.Count; i++)
            {
                int randInt = rand.Next (0, deck.Count);

                if (randInt != i)
                {
                    Card temp = deck[i];
                    deck[i] = deck[randInt];
                    deck[randInt] = temp;
                }
            }

            return deck;
        }
    }
}