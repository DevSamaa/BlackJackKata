using System;
using System.Collections.Generic;
using BlackJackKata;
using Xunit;

namespace BlackJackTests
{
    public class CardRemoverTests
    {
        CardRemover cardRemover = new CardRemover();

        public CardRemoverTests()
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
            var removedCard = cardRemover.RemoveCardFromDeck(deckOfCards);

            //assert
            Assert.Equal(newCountOfDeck, deckOfCards.Count);
            Assert.DoesNotContain(removedCard, deckOfCards);
        }

        

        [Fact]
        public void AddCardToPlayerList_GivenCard_ReturnsListOfCards()
        {
            //arrange
            var card = deckOfCards[0];
            //action
            var listOfPlayerCards = cardRemover.AddCardToPlayerList(card);

            //assert
            Assert.Contains(card, listOfPlayerCards);
            Assert.Single(listOfPlayerCards);

        }

    }
}
