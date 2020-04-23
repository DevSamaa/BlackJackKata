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



        //TODO -> write this with inline data for all 4 suits
        [Fact]
        public void CreateDeck_GivenCardShouldExist3()
        {

            var allClubs = deckOfCards.FindAll(card => card.suit.Contains("CLUB"));

            Assert.Equal(13, allClubs.Count);


        }
    }
}
