using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackJack!");

            //creates and shuffles the deck
            var deck = new Deck();
            var shuffledDeck = deck.CreateShuffledDeck();

            var cardHandler = new CardHandler();
            var player = new Player();
            //TODO: once this works (in a refactored way) for 1 player, add player2!
            //var player2 = new Player();

            var gamemaster = new GameMaster();
            gamemaster.dealingInitialCards(cardHandler, shuffledDeck, player);


            while (true)
            {
                // Calculate points and show them to everyone
                var playersPoints = gamemaster.showCardsAndPoints(player);

                //Get UserInput (Hit or Stay)
                var userInput = new UserInput();
                var validatedString = userInput.UserSelection();

                //if they selected hit this should happen
                if (validatedString == "1")
                {
                    //TODO --> group the next two lines together as issue1Card
                    var removedCard3 = cardHandler.RemoveCardFromDeck(shuffledDeck);
                    cardHandler.AddCardToPlayersCards(removedCard3, player.playersCards);


                    playersPoints = player.CalculatePoints();
                }
                else
                {
                    break;
                }

                //Check If Bust
                if (playersPoints>21)
                {
                    player.ShowPoints(playersPoints);
                    player.ShowCards();
                    Console.WriteLine("You have gone bust. You lose. Game Over.");
                    return;
                }

            }

            //TODO the other players turn begins - check whether the other person has gone bust, or decided to stay
            Console.WriteLine("dealers turn is starting");


        }
    }
}

