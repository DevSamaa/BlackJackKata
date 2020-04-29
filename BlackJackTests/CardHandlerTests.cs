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

        List<CardModel> deckOfCards = new List<CardModel>() {

                new CardModel("CLUB", "A", 1),
                new CardModel("DIAMOND", "K", 10),
                new CardModel("SPADE", "7", 7),
                new CardModel("HEART", "Q", 10)

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
            var listOfPlayerCards = new List<CardModel>();

            //action
            cardHandler.AddCardToPlayersCards(card,listOfPlayerCards);

            //assert
            Assert.Contains(card, listOfPlayerCards);
            Assert.Single(listOfPlayerCards);
        }

    }
}
