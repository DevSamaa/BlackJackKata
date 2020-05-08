﻿using System;
using System.Collections.Generic;

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
