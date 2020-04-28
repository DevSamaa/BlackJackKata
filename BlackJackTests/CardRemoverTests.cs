using System;
using System.Collections.Generic;
using BlackJackKata;
using Xunit;

namespace BlackJackTests
{
    public class CardRemoverTests
    {
        public CardRemoverTests()
        {
        }
        public static IEnumerable<object[]> DeckOfCards()
        {
            var deckOfCards = new List<CardModel>() {

                new CardModel("CLUB", "A", 1),
                new CardModel("DIAMOND", "K", 10),
                new CardModel("SPADE", "7", 7),
                new CardModel("HEART", "Q", 10)

            };
            yield return new object[] { deckOfCards };

        }

        [Theory]
        [MemberData(nameof(DeckOfCards))]
        public void RemoveCard_GivenADeck_ShouldReturnDeckMinusOne_AndListWithOneCard(List<CardModel> currentDeck)
        {
            //arrange
            var cardRemover = new CardRemover();

            //action
            var listOfRemovedCard = cardRemover.RemoveCard(currentDeck);
            var newCountOfDeck = currentDeck.Count - 1;

            //assert
            Assert.Equal(newCountOfDeck, currentDeck.Count);
            Assert.True(listOfRemovedCard.Count == 1);
        }


       
    }
}
