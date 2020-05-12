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

        [Fact]
        public void CalculatePoints_GivenAce()
        {
            //arrange
            List<Card> sampleCards = new List<Card>() {

                new Card("CLUB", "A", 1),
                new Card("HEART", "A", 1)

            };

            player.playersCards.AddRange(sampleCards);

            //action
            var currentPoints = player.CalculatePoints();


            //assert
            Assert.Equal(12, currentPoints);

        }



        // Like the test above but with Member Data-------------------------------------------------------------

        public static IEnumerable<object[]> sampleCards()
        {
            yield return new object[] { new List<Card>() { new Card("CLUB", "A", 1), new Card("HEART", "A", 1) }, 12 };
            yield return new object[] { new List<Card>() { new Card("CLUB", "9", 9), new Card("HEART", "A", 1) }, 20 };
            yield return new object[] { new List<Card>() { new Card("CLUB", "10", 10), new Card("HEART", "A", 1) }, 21 };
            yield return new object[] { new List<Card>() { new Card("CLUB", "9", 9), new Card("HEART", "A", 1), new Card("SPADE", "A", 1) }, 21 };

        }

        [Theory]

        [MemberData(nameof(sampleCards))]
        public void CalculatePoints_GivenAce_MD(List<Card> incomingList, int expectedPoints)
        {
            //arrange
            //player.playersCards.AddRange(incomingList);
            player.playersCards = incomingList;

            //act
            var currentPoints = player.CalculatePoints();

            //assert
            Assert.Equal(expectedPoints, currentPoints);
        }
    }


}
