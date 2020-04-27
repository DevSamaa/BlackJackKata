using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class CardRemover
    {
        public CardRemover()
        {
        }

        //public List<CardModel> RemoveCards(List<CardModel> incomingDeck)
        //{
        //    return new List<CardModel>();
            
        //}

        //public List<CardModel> RemoveCards(List<CardModel> incomingDeck)
        //{
        //    var newList = new List<CardModel>();

        //    newList = incomingDeck.RemoveAt(0);

        //    return newList;
        //}


        //TODO - this probably needs to be refactored to either return a single CardModel object, which is then added to a list, OR it should take a list "PlayersCards" as an argument and add to that list.(I think the first option is probably easier to test.
        public List<CardModel> RemoveCards2(List<CardModel> incomingDeck)
        {
            var newList = new List<CardModel>();

            newList.Add(incomingDeck[0]);

            incomingDeck.RemoveAt(0);

            return newList;

            //return new List<CardModel>();

        }
    }
}

