using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class CardHandler
    {
        public CardHandler()
        {
        }

        public void DealOneCard(List<Card> incomingDeck, List<Card> playersCards)
        {
            var removedCard = RemoveCardFromDeck(incomingDeck);
            playersCards.Add(removedCard);
        }

        private Card RemoveCardFromDeck(List<Card> incomingDeck)
        {
            var pickedCard = incomingDeck[0];
            incomingDeck.RemoveAt(0);
            return pickedCard;
        }


    }
}

