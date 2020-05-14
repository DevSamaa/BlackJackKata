using System;
namespace BlackJackKata
{
    public class EndOfGame
    {
        public EndOfGame()
        {
        }

        public void FindWinnner(int humanScore, int dealerScore)
        {
            if (humanScore > dealerScore)
            {
                Console.WriteLine("Human wins");
            }
            else if (humanScore == dealerScore)
            {
                Console.WriteLine("It's a tie! Both the Human and the Dealer win!");
            }
            else
            {
                Console.WriteLine("Dealer Wins");
            }
        }
    }
}
