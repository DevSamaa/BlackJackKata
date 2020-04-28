using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class CardRemover
    {
        public CardRemover()
        {
        }


        public List<CardModel> RemoveCard(List<CardModel> incomingDeck)
        {
            var newList = new List<CardModel>();

            newList.Add(incomingDeck[0]);

            incomingDeck.RemoveAt(0);

            return newList;


        }


        //TODO - the method above probably needs to be refactored. Some ideas:
        //1) return a single <CardModel> object, which is then added to a list in a different method
        //2) OR it should take a list "playersCards" as a second argument and add ncomingDeck[0] to that list.(I think the first option is probably easier to test.)

        //This is just a attempt at refactoring the method above, I'll continue with this later. 
        //public CardModel RefactoredAttempt_RemoveCard(List<CardModel> incomingDeck)
        //{

        //    var pickedCard = new CardModel(incomingDeck[0].suit, incomingDeck[0].face, incomingDeck[0].points);

        //    incomingDeck.RemoveAt(0);

        //    return pickedCard;

        //}
    }
}

