using System;
using System.Collections.Generic;

namespace Cards
{
    class Hand
    {
        public const int HandSize = 13;
        //private PlayingCard[] cards = new PlayingCard[HandSize];
        private List<PlayingCard> cards = new List<PlayingCard>(HandSize);
        //private int playingCardCount = 0;

        public void AddCardToHand(PlayingCard cardDealt)
        {
            //if (this.playingCardCount >= HandSize)
            if (this.cards.Count >= HandSize)
            {
                throw new ArgumentException("Too many cards");
            }
            //this.cards[this.playingCardCount] = cardDealt;
            //this.playingCardCount++;
            this.cards.Add(cardDealt);
        }

        public override string ToString()
        {
            string result = "";
            foreach (PlayingCard card in this.cards)
            {
                result += card.ToString() + "\n";
            }

            return result;
        }
    }
}