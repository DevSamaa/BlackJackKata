using System;
using System.Collections.Generic;
using BlackJackKata;
using Xunit;

namespace BlackJackTests
{
    public class CardHandlerTests
    {
        CardHandler cardHandler = new CardHandler();

        public CardHandlerTests()
        {
        }

        List<Card> deckOfCards = new List<Card>() {

                new Card("CLUB", "A", 1),
                new Card("DIAMOND", "K", 10),
                new Card("SPADE", "7", 7),
                new Card("HEART", "Q", 10)

            };
           

       [Fact]
        public void RemoveCardFromDeck_GivenADeck_ShouldReturnCard_AndDeckMinusOne()
        {
            //arrange
            var newCountOfDeck = deckOfCards.Count - 1;

            //action
            var removedCard = cardHandler.RemoveCardFromDeck(deckOfCards);

            //assert
            Assert.Equal(newCountOfDeck, deckOfCards.Count);
            Assert.DoesNotContain(removedCard, deckOfCards);
        }


        [Fact]
        public void AddCardToPlayersCards_GivenCard_ReturnsListOfCards()
        {
            //arrange
            var card = deckOfCards[0];
            var listOfPlayerCards = new List<Card>();

            //action
            cardHandler.AddCardToPlayersCards(card,listOfPlayerCards);

            //assert
            Assert.Contains(card, listOfPlayerCards);
            Assert.Single(listOfPlayerCards);
        }

    }
}
