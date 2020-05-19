using System;
using Xunit;
using BlackJackKata;

namespace BlackJackTests
{
    public class UserInputShould
    {
        public UserInput userInput = new UserInput();

        [Theory]
        [InlineData("1",true)]
        [InlineData("0", true)]
        [InlineData("2", false)]
        [InlineData("hello", false)]
        public void ValidateInput(string userSelection, bool expectedOutcome)
        {
            var actual = userInput.ValidateInput(userSelection);
            Assert.Equal(expectedOutcome, actual);
        }
    }
}
