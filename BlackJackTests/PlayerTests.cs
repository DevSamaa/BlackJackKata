using System;
using System.Collections.Generic;
using BlackJackKata;
using Xunit;

namespace BlackJackTests
{
    public class PlayerShould
    {
        public Player player;

        public PlayerShould()
        {
            player = new Player();
        }


        [Fact]
        public void CalculatePoints_GivenListOfCards()
        {
            //arrange
            List <CardModel > sampleCards = new List<CardModel>() {

                new CardModel("CLUB", "A", 1),
                new CardModel("DIAMOND", "6", 6),
                new CardModel("SPADE", "7", 7),
                new CardModel("HEART", "Q", 10)

            };

            player.playersCards.AddRange(sampleCards);

            //action
            var currentPoints = player.CalculatePoints();


            //assert
            Assert.Equal(24, currentPoints);

        }
    }


}

