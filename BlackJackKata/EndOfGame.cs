using System;
namespace BlackJackKata
{
    public class EndOfGame
    {
        public EndOfGame()
        {
        }

        public string FindWinnner(int humanScore, int dealerScore)
        {
            if (humanScore > dealerScore)
            {
                return "Human wins";
            }
            else if (humanScore == dealerScore)
            {
                return "It's a tie! Both the Human and the Dealer win!";
            }
            else
            {
               return "Dealer Wins";
            }
        }
    }
}
