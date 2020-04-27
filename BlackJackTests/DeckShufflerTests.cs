using System;
using Xunit;
using BlackJackKata;

namespace BlackJackTests
{
    public class DeckShufflerTests
    {
        public DeckShufflerTests()
        {
        }

        

        [Fact]
        public void ShuffleTheDeck_GivenADeck_ShouldReturnDifferentDeck()
        {
            //arrange
            var deckCreator = new DeckCreator();
            var deckOfCards = deckCreator.CreateDeck();
            var deckShuffler = new DeckShuffler();

            //action
            var shuffledDeck = deckShuffler.ShuffleTheDeck(deckOfCards);

            //assert
            //counts of both lists should be the same (52)
            Assert.Equal(deckOfCards.Count, shuffledDeck.Count);
            //actual lists should not be the same
            Assert.NotEqual(deckOfCards, shuffledDeck);
        }

        [Fact]
        public void ShuffleTheDeck_GivenADeck_ShouldReturnDifferentDeckEachTime()
        {
            //arrange
            var deckCreator = new DeckCreator();
            var deckOfCards = deckCreator.CreateDeck();
            var deckShuffler = new DeckShuffler();

            //action
            var shuffledDeckOne = deckShuffler.ShuffleTheDeck(deckOfCards);
            var shuffledDeckTwo = deckShuffler.ShuffleTheDeck(deckOfCards);

            //assert
            //counts of both lists should be the same 
            Assert.Equal(shuffledDeckOne.Count, shuffledDeckTwo.Count);
            //actual lists should not be the same
            Assert.NotEqual(shuffledDeckOne, shuffledDeckTwo);
        }

    }
}

