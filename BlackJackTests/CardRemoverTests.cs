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
        //Question for mentors => is Member Data only able to test an array, not a list of objects?
        //-->test whether this function can remove 1 item from a given list.
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

        //--third attempt of the test
        [Theory]
        [MemberData(nameof(DeckOfCards))]
        public void RemoveCards2_GivenADeck_ShouldReturnListOfCardThatWasDrawn_AnotherTry(List<CardModel> incomingDeck, int incomingDeckCount)
        {
            //arrange
            var cardRemover = new CardRemover();
            var newIncomingDeckCount = incomingDeckCount - 1;

            //action
            var removedCard = cardRemover.RemoveCards2(incomingDeck);

            //assert
            Assert.Equal(newIncomingDeckCount, incomingDeck.Count);
        }


        ////old test that was BAD! ----------------------------------------------
        //public static IEnumerable<object[]> DeckOfCards()
        //{
        //    var deckOfCards = new List<CardModel>() {

        //        new CardModel("CLUB", "A", 1),
        //        new CardModel("DIAMOND", "K", 10),
        //        new CardModel("SPADE", "7", 7),
        //        //new CardModel("HEART", "Q", 10)

        //    };
        //    yield return new object[] { deckOfCards};

        //}

        ////-----------for the second attempt of the test (the first one just tried to call the "RemoveCards" method that does not do anything.
        //[Theory]
        //[MemberData(nameof(DeckOfCards))]
        //public void RemoveCards2_GivenADeck_ShouldReturnListOfCardThatWasDrawn(List<CardModel> incomingDeck)
        //{
        //    //arrange
        //    var cardRemover = new CardRemover();

        //    //action
        //    var outgoingDeck = cardRemover.RemoveCards2(incomingDeck);
        //    var OutgoingDeckExpectedCount = incomingDeck.Count - 1;

        //    //assert
        //    Assert.Equal(OutgoingDeckExpectedCount, outgoingDeck.Count);
        //    Assert.True(incomingDeck.Count > outgoingDeck.Count);

        //}
    }
}
