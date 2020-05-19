using System;
using System.Collections.Generic;
using BlackJackKata;
using Xunit;

namespace BlackJackTests
{
    public class CardHandlerShould
    {
        CardHandler cardHandler = new CardHandler();

        public CardHandlerShould()
        {
        }

        List<Card> deckOfCards = new List<Card>() {

                new Card("CLUB", "A", 1),
                new Card("DIAMOND", "K", 10),
                new Card("SPADE", "7", 7),
                new Card("HEART", "Q", 10)

            };
           

       [Fact]
        public void RemoveOneCard_GivenADeck()
        {
            //arrange
            var newCountOfDeck = deckOfCards.Count - 1;

            //action
            cardHandler.RemoveCardFromDeck(deckOfCards);

            //assert
            Assert.Equal(newCountOfDeck, deckOfCards.Count);
        }


        [Fact]
        public void ReturnADeckWithoutRemovedCard()
        {

            //action
            var removedCard = cardHandler.RemoveCardFromDeck(deckOfCards);

            //assert
            Assert.DoesNotContain(removedCard, deckOfCards);

        }






    }
}
