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
            //add up all the .points on a card
            //except where the card.face is A
                //-> make A worth 11 points, unless that would make them go bust, then A= 1 point.

            //what would make a player go bust? If allpoints = 11
            int allpoints = 0;
            foreach (var card in playersCards)
            {
                allpoints = allpoints + card.points;
            }


            //if allpoints <12 , then we want to check whether you have an ace (card.face) --> if true add 10 points
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
            if (playersPoints > 21)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
