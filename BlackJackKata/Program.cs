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

            //TODO: once this works (in a refactored way) for 1 player, add player2!
            var gamemaster = new GameMaster();
            var cardHandler = new CardHandler();

            var player1 = new Player();
            var player2 = new Player();
            Player[] allPlayers = { player1, player2 };

            foreach (var player in allPlayers)
            {
                int playerScore = 0;
                while (playerScore < 21)
                {

                    gamemaster.dealInitialCards(cardHandler, shuffledDeck, player);
                    playerScore = gamemaster.playGame(player, cardHandler, shuffledDeck);
                    Console.WriteLine("You're turn is over");
                }
                

            }
            //TODO check whether the player person has gone bust, if they have the game should be over
            //TODO I need to somehow return
            //TODO win at 21! No need to stay! should be automatic
           


        }
    }
}

