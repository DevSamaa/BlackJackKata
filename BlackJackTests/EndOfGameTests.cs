using System;
using BlackJackKata;
using Xunit;

namespace BlackJackTests
{
    public class EndOfGameShould
    {
        public EndOfGame endOfGame = new EndOfGame();

        [Theory]
        [InlineData(20,17, "Human wins")]
        [InlineData(17, 20, "Dealer Wins")]
        [InlineData(19, 19, "It's a tie! Both the Human and the Dealer win!")]

        public void FindWinnner(int humanScore, int dealerScore, string expectedResult)
        {
            var actual = endOfGame.FindWinnner(humanScore, dealerScore);
            Assert.Equal(expectedResult, actual);
        }


    }
}
