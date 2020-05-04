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
            List <Card > sampleCards = new List<Card>() {

                new Card("CLUB", "A", 1),
                new Card("DIAMOND", "6", 6),
                new Card("SPADE", "7", 7),
                new Card("HEART", "Q", 10)

            };

            player.playersCards.AddRange(sampleCards);

            //action
            var currentPoints = player.CalculatePoints();


            //assert
            Assert.Equal(24, currentPoints);

        }
    }


}

