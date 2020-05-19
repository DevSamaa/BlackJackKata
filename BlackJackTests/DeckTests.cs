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
        public void CreateDeck_WithLengthof52_UsingLengthMethod()
        {
            var cardArray = deckOfCards.ToArray();

            Assert.Equal(52, cardArray.Length);
        }

        [Fact]
        public void CreateDeck_WithLengthof52_UsingCountMethod()
        {
            
            var countOfCards = deckOfCards.Count();
            Assert.Equal(52, countOfCards);
        }

        
        [Fact]
        public void CreateADeckWith13CLUBCards()
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
        public void CreateADeckWithAll4Suits(string incomingSuit, int expectedSuits)
        {
            var allClubs = deckOfCards.FindAll(card => card.suit.Contains(incomingSuit));
            Assert.Equal(expectedSuits, allClubs.Count);
        }


        [Fact]
        public void ShuffleTheDeck()
        {
            //arrange
            var unshuffledDeckOfCards = deck.CreateCards();

            //action
            var shuffledDeck = deck.ShuffleCards(unshuffledDeckOfCards);

            //assert
            //counts of both lists should be the same (52)
            Assert.Equal(unshuffledDeckOfCards.Count, shuffledDeck.Count);

            //order of lists should not be the same
            var result = isNotSameOrder(unshuffledDeckOfCards, shuffledDeck);
       
            Assert.True(result);
        }


        public bool isNotSameOrder(List<Card> unshuffledDeck, List<Card> shuffledDeck)
        {
            bool result = false;
            for (int i = 0; i < unshuffledDeck.Count; i++)
            {
             
                if (unshuffledDeck[i].face == shuffledDeck[i].face && unshuffledDeck[i].suit == shuffledDeck[i].suit)
                {
                    continue;
                }
                else
                {
                    result = true;
                    break;
                }
            }
            return result;
        }


        [Fact]
        public void ShuffleTheDeck_GivenADeck_ShouldReturnDifferentDeckEachTime()
        {
            //arrange
            var unshuffledDeckOfCards = deck.CreateCards();

            //action
            var shuffledDeckOne = deck.ShuffleCards(unshuffledDeckOfCards);
            var shuffledDeckTwo = deck.ShuffleCards(unshuffledDeckOfCards);

            //order of lists should not be the same
            var result = isNotSameOrder(shuffledDeckOne, shuffledDeckTwo);

            Assert.True(result);
        }
    }
}

