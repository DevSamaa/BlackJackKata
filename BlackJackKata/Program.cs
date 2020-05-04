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

            //TODO: once this works (in a refactored way) for 1 player, add player2!
            var player = new Player();

            var gamemaster = new GameMaster();
            gamemaster.dealInitialCards(cardHandler, shuffledDeck, player);

            gamemaster.playGame(player, cardHandler,shuffledDeck);


            //TODO the other players turn begins - check whether the other person has gone bust, or decided to stay
            Console.WriteLine("dealers turn is starting");


        }
    }
}

