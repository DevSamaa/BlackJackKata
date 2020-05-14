using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class GameMaster
        
    {
        private CardHandler _cardHandler;
        private List<Card> _shuffledDeck;

        public GameMaster(CardHandler cardHandler = null, Deck deck = null)
        {
            _cardHandler = cardHandler ?? new CardHandler();
           var _deck = deck ?? new Deck();
            _shuffledDeck = _deck.CreateShuffledDeck();
        }

        private void DealInitialCards(Player player)
        {
            _cardHandler.DealOneCard(_shuffledDeck, player.playersCards);
            _cardHandler.DealOneCard(_shuffledDeck, player.playersCards);
         
        }


        private int ShowCardsAndPoints(Player player)
        {
            var playersPoints = player.CalculatePoints();
            player.ShowCards();
            player.ShowPoints(playersPoints);
            return playersPoints;
        }

        

        public void PlayHand(Player player)
        {
            DealInitialCards(player);

            while (true)
            {
                ShowCardsAndPoints(player);

                if (player.IsBust())
                {
                    Console.WriteLine("You've gone bust. You lose.");
                    break;
                }

                var wantsToHit = player.WantsToHit();

                if (wantsToHit)
                {
                    _cardHandler.DealOneCard(_shuffledDeck, player.playersCards);
                }
                else
                {
                    return;
                }

            }
        }



    }
}


