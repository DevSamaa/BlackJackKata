using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class DeckCreator
    {
       
        string[] suits = {"CLUB", "DIAMOND", "HEART", "SPADE" };
        string[] faces = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        int[] points = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10};

        public DeckCreator()
        {
        }

    


        public List<CardModel> CreateDeck()
        {
            List<CardModel> deckOfCards = new List<CardModel>();

            foreach (var item in suits)
            {
                for (int index = 0; index < 13; index++)
                {
                    var aCard = new CardModel(item, faces[index], points[index]);
                    deckOfCards.Add(aCard);

                }

            }

            return deckOfCards;

        }


    }
}
