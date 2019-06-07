namespace DeckOfCards.CardClass
{
    class Card
    {
        private string stringVal;
        private string suit;
        private int val;
        
        public Card (string strVal, string suitVal, int value)
        {
            this.stringVal = strVal;
            this.suit = suitVal;
            this.val = value;
        }


    }
}