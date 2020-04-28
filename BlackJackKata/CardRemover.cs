using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class CardRemover
    {
        public CardRemover()
        {
        }


        public CardModel RemoveCardFromDeck(List<CardModel> incomingDeck)
        {

            var pickedCard = incomingDeck[0];

            incomingDeck.RemoveAt(0);

            return pickedCard;
              
        }


        public List<CardModel> AddCardToPlayerList(CardModel incomingCard)
        {
            var newList = new List<CardModel>();
            newList.Add(incomingCard);
            return newList;
        }
       

    }
}

