using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class CardHandler
    {
        public CardHandler()
        {
        }


        public CardModel RemoveCardFromDeck(List<CardModel> incomingDeck)
        {

            var pickedCard = incomingDeck[0];

            incomingDeck.RemoveAt(0);

            return pickedCard;
              
        }

        public void AddCardToPlayersCards(CardModel incomingCard, List<CardModel> playersCards)
        {
            playersCards.Add(incomingCard);
        }


    }
}

