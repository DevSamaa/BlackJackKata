using System;
using Xunit;
using BlackJackKata;
using System.Linq;
using System.Collections.Generic;

namespace BlackJackTests
{
    public class DeckShould
    {
        private Deck deck; 
        private List<Card> deckOfCards;


        public DeckShould()
        {
            deck = new Deck();
            deckOfCards = deck.CreateShuffledDeck();
        }

        [Fact]
        public void CreateDeck_ShouldHaveLengthof52_UsingLengthMethod()
        {
            var cardArray = deckOfCards.ToArray();

            Assert.Equal(52, cardArray.Length);
        }

        [Fact]
        public void CreateDeck_ShouldHaveLengthof52_UsingCountMethod()
        {
            
            var countOfCards = deckOfCards.Count();
            Assert.Equal(52, countOfCards);
        }


        [Fact]
        public void CreateDeck_GivenCardShouldExist()
        {
            //arrange
            var unshuffledDeckOfCards = deck.CreateCards();

            Assert.Equal("CLUB", unshuffledDeckOfCards[0].suit);
            Assert.Equal("A", unshuffledDeckOfCards[0].face);
        }



        
        [Fact]
        public void CreateDeck_GivenCardShouldExist_UsingFindAll()
        {

            var allClubs = deckOfCards.FindAll(card => card.suit.Contains("CLUB"));

            Assert.Equal(13, allClubs.Count);


        }


        //---Same test as above but this time with InlineData
        [Theory]
        [InlineData("CLUB", 13)]
        [InlineData("DIAMOND", 13)]
        [InlineData("HEART", 13)]
        [InlineData("SPADE", 13)]
        public void CreateDeck_GivenCardShouldExist_UsingFindAll_Inline(string incomingSuit, int expectedSuits)
        {

            var allClubs = deckOfCards.FindAll(card => card.suit.Contains(incomingSuit));

            Assert.Equal(expectedSuits, allClubs.Count);


        }


        [Fact]
        public void ShuffleTheDeck_GivenADeck_AndReturnDifferentDeck()
        {
            //arrange
            var unshuffledDeckOfCards = deck.CreateCards();

            //action
            var shuffledDeck = deck.ShuffleCards(unshuffledDeckOfCards);

            //assert
            //counts of both lists should be the same (52)
            Assert.Equal(unshuffledDeckOfCards.Count, shuffledDeck.Count);
            //actual lists should not be the same
            Assert.NotEqual(unshuffledDeckOfCards, shuffledDeck);
        }

        [Fact]
        public void ShuffleTheDeck_GivenADeck_ShouldReturnDifferentDeckEachTime()
        {
            //arrange
            var unshuffledDeckOfCards = deck.CreateCards();

            //action
            var shuffledDeckOne = deck.ShuffleCards(unshuffledDeckOfCards);
            var shuffledDeckTwo = deck.ShuffleCards(unshuffledDeckOfCards);

            //assert
            //counts of both lists should be the same 
            Assert.Equal(shuffledDeckOne.Count, shuffledDeckTwo.Count);
            //actual lists should not be the same
            Assert.NotEqual(shuffledDeckOne, shuffledDeckTwo);
        }
    }
}

