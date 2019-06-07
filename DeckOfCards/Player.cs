using System;
using System.Collections.Generic;
using DeckOfCards.CardClass;
using DeckOfCards.DeckClass;

namespace DeckOfCards.PlayerClass
{
    class Player
    {
        private string name;
        private List<Card> hand;

        public Player (string playerName)
        {
            this.name = playerName;
            this.hand = new List<Card> ();
        }

        public Card Draw (Deck deck, List<Card> playerHand)
        {
            Card newCard = deck.DealCard ();

            playerHand.Add (newCard);

            return newCard;
        }

        public Card Discard (List<Card> playerHand, int index)
        {
            Card discardCard = playerHand[index];
            playerHand.RemoveAt (index);

            return discardCard;
        }
    }
}