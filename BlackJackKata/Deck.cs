using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackKata
{
    public class Deck
    {
        string[] suits = {"CLUB", "DIAMOND", "HEART", "SPADE" };
        string[] faces = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        int[] points = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10};

        public Deck()
        {
        }

        private List<Card> CreateCards()
        {
            List<Card> deckOfCards = new List<Card>();

            foreach (var item in suits)
            {
                for (int index = 0; index < 13; index++)
                {
                    var aCard = new Card(item, faces[index], points[index]);
                    deckOfCards.Add(aCard);
                }

            }
            return deckOfCards;
        }


        private List<Card> ShuffleCards(List<Card> incomingCards)
        {
            var shuffledDeck = incomingCards.OrderBy(x => Guid.NewGuid()).ToList();
            return shuffledDeck;
        }


        public List<Card> CreateShuffledDeck()
        {
            var deckOfCards = CreateCards();
            var shuffledDeck = ShuffleCards(deckOfCards);
            return shuffledDeck;
        }
    }
}
