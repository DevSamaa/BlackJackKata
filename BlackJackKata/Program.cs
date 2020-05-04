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

            var gamemaster = new GameMaster();
            var cardHandler = new CardHandler();

            var player1 = new Player();
            var player2 = new Player();

            while (true)
            {
                gamemaster.dealInitialCards(cardHandler, shuffledDeck, player1);
                var player1Score = gamemaster.playGame(player1, cardHandler, shuffledDeck);
                if (player1Score >21)
                {
                    break;
                }
                Console.WriteLine("You're turn is over, the dealers turn begins");

                gamemaster.dealInitialCards(cardHandler, shuffledDeck, player2);
                var player2Score = gamemaster.playGame(player2, cardHandler, shuffledDeck);
                if (player2Score > 21)
                {
                    break;
                }

                //check who won
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

                break;
            }
            

            


        }
    }
}
//TODO win at 21! No need to stay! should be automatic

//Player[] allPlayers = { player1, player2 };
//foreach (var player in allPlayers)
//{
//    int playerScore = 0;
//    while (playerScore < 21)
//    {

//        gamemaster.dealInitialCards(cardHandler, shuffledDeck, player);
//        playerScore = gamemaster.playGame(player, cardHandler, shuffledDeck);
//        Console.WriteLine("You're turn is over");
//    }
//}