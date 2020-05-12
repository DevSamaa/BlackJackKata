using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackKata
{
    public class Player
    {

        public List<Card> playersCards = new List<Card>();
        

        public Player()
        {
        }

        public void ShowCards()
        {
            Console.WriteLine($"Your current cards are: ");

            foreach (var card in playersCards)
            {
                Console.WriteLine($"[{card.face}] [{card.suit}]");
            }
        }

        public int CalculatePoints()
        {
            int allpoints = 0;
            foreach (var card in playersCards)
            {
                allpoints = allpoints + card.points;
            }

            if ( allpoints <12 && playersCards.Any(card => card.face =="A"))
            {
                allpoints = allpoints + 10;
            }
            return allpoints;

        }



        public void ShowPoints(int playersPoints)
        {
            Console.WriteLine($"You currently have {playersPoints} points.");
        }


        public bool isBust()
        {
            var playersPoints = CalculatePoints();
            return playersPoints > 21;

        }

        public bool WantsToHit()
        {
            var userInput = new UserInput();
            var validatedUserSelection = userInput.UserSelection();

            //this is called an inline conditional!?
            return validatedUserSelection == "1";

            //Here is the ternary operator version:
            //return validatedString == "1" ? true : false;

            // This uses an If statment:
            //if (validatedString =="1")
            //{
            //    return true;
            //}
            //return false;


        }

    }
}


//TODO check that all methods start with a capital letter, so IsBust, not isBust!!