using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class CardHandler
    {
        public CardHandler()
        {
        }


        public Card RemoveCardFromDeck(List<Card> incomingDeck)
        {

            var pickedCard = incomingDeck[0];

            incomingDeck.RemoveAt(0);

            return pickedCard;
              
        }

        public void AddCardToPlayersCards(Card incomingCard, List<Card> playersCards)
        {
            playersCards.Add(incomingCard);
        }


    }
}

