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
        //Question for mentors => is Member Data only able to test an array of objects, not a list of objects? Why can't I use List<CardModel>?
        public static IEnumerable<object[]> DeckOfCards()
        {
            var deckOfCards = new List<CardModel>() {

                new CardModel("CLUB", "A", 1),
                new CardModel("DIAMOND", "K", 10),
                new CardModel("SPADE", "7", 7),
                new CardModel("HEART", "Q", 10)

            };
            yield return new object[] { deckOfCards, deckOfCards.Count };

        }

        [Theory]
        [MemberData(nameof(DeckOfCards))]
        public void RemoveCard_GivenADeck_ShouldReturnDeckMinusOne_AndListWithOneCard(List<CardModel> currentDeck, int initialCountOfDeck)
        {
            //arrange
            var cardRemover = new CardRemover();
            var newCountOfDeck = initialCountOfDeck - 1;

            //action
            var listOfRemovedCard = cardRemover.RemoveCard(currentDeck);

            //assert
            Assert.Equal(newCountOfDeck, currentDeck.Count);
            Assert.True(listOfRemovedCard.Count == 1);
        }


       
    }
}
