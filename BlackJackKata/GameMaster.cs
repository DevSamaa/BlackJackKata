using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class GameMaster
        //This class is responsible for playing a hand ( that includes dealing the initial 2 cards, showing the players points and cards,  checking if they have gone bust, and asking them whether they want to hit or stay.
    {
        private CardHandler _cardHandler;
        private List<Card> _shuffledDeck;

        public GameMaster(CardHandler cardHandler= null,Deck deck = null)
        {
            _cardHandler = cardHandler ?? new CardHandler();
           var _deck = deck ?? new Deck();
            _shuffledDeck = _deck.CreateShuffledDeck();
        }

        public void dealInitialCards(Player player)
        {
            var removedCard1 = _cardHandler.RemoveCardFromDeck(_shuffledDeck);
            _cardHandler.AddCardToPlayersCards(removedCard1, player.playersCards);

            var removedCard2 = _cardHandler.RemoveCardFromDeck(_shuffledDeck);
            _cardHandler.AddCardToPlayersCards(removedCard2, player.playersCards);
        }


        public int showCardsAndPoints(Player player)
        {
            var playersPoints = player.CalculatePoints();
            player.ShowPoints(playersPoints);
            player.ShowCards();
            return playersPoints;
        }

        

        public void playGame(Player player)
        {
            //you get the first 2 cards
            dealInitialCards(player);
            while (true)
            {
                // Calculate points and show them to everyone
                var playersPoints = showCardsAndPoints(player);

                //check if bust
                if (player.isBust())
                {
                    Console.WriteLine("You've gone bust. You lose.");
                    break;
                }

                //Decide whether player wants to hit or stay
                var wantsToHit = player.WantsToHit();

                //if they selected hit this should happen
                if (wantsToHit)
                {
                    var removedCard = _cardHandler.RemoveCardFromDeck(_shuffledDeck);
                    _cardHandler.AddCardToPlayersCards(removedCard, player.playersCards);

                }
                else
                {
                    return;
                }

            }
        }


        public void findWinnner(int player1Score, int player2Score)
        {
            if (player1Score > player2Score)
            {
                Console.WriteLine("Player1 wins");
            }
            else if (player1Score == player2Score)
            {
                Console.WriteLine("It's a tie! Both player1 and player2 win!");
            }
            else
            {
                Console.WriteLine("Player2Wins");
            }
        }

    }
}


//We are going to start with virtual and override.
//Later we will have an abstract player class.