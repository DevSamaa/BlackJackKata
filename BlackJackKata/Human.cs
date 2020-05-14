using System;
namespace BlackJackKata
{
    public class Human : Player
    {
        public Human()
        {
        }

        public override bool WantsToHit()
        {
            var userInput = new UserInput();
            var validatedUserSelection = userInput.UserSelection();

            return validatedUserSelection == "1";
        }

        
    }
}
