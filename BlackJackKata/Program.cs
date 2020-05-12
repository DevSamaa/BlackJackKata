using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    class Program
    {
        //Note to myself: this class should be responsible managing the players as well as the rules (who won, whose turn is it, ect).

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackJack!");

            var gamemaster = new GameMaster();

            var player1 = new Player();
            var player2 = new Dealer();

            
                gamemaster.playGame(player1);
                if (player1.isBust())
                {
                    Console.WriteLine("Player2 wins");
                    return;
                }
                Console.WriteLine("You're turn is over, the dealers turn begins");

               gamemaster.playGame(player2);
                if (player2.isBust())
                {
                    Console.WriteLine("Player1 wins");
                    return;
                }

                var player1Score =player1.CalculatePoints();
                var player2Score = player2.CalculatePoints();

                gamemaster.findWinnner(player1Score, player2Score);

            
           
            

        }
    }
}

//Notes for Saiyi :)
//--> We are going to start with virtual and override.
//Later we will have an abstract player class.

//TODO check that all methods start with a capital letter, so IsBust, not isBust!!