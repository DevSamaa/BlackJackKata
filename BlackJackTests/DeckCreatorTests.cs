using System;
using Xunit;
using BlackJackKata;
using System.Linq;
using System.Collections.Generic;

namespace BlackJackTests
{
    public class DeckCreatorTests
    {
        private DeckCreator deckCreator; 
        private List<CardModel> deckOfCards;


        public DeckCreatorTests()
        {
            deckCreator = new DeckCreator();
            deckOfCards = deckCreator.CreateDeck();
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

            Assert.Equal("CLUB", deckOfCards[0].suit);
            Assert.Equal("A", deckOfCards[0].face);
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
    }
}

