using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackKata
{
    public abstract class Player
    {

        public List<Card> playersCards = new List<Card>();
        

        public Player()
        {
        }

        public void ShowCards()
        {
            Console.WriteLine($"Your cards: ");

            foreach (var card in playersCards)
            {
                Console.WriteLine($"[{card.face}] [{card.suit}]");
            }
        }

        public void ShowPoints(int playersPoints)
        {
            Console.WriteLine($"You currently have {playersPoints} points.\n");
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

        public bool IsBust()
        {
            var playersPoints = CalculatePoints();
            return playersPoints > 21;

        }

        public abstract bool WantsToHit();
        

    }
}


