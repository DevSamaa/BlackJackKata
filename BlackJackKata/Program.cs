using System;

namespace BlackJackKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackJack!");

            //creates and shuffles the deck
            var deckCreator = new DeckCreator();
            var deckOfCards = deckCreator.CreateDeck();
            var deckShuffler = new DeckShuffler();
            var shuffledDeck = deckShuffler.ShuffleTheDeck(deckOfCards);

            // Player is just a model, CardHandler is only logic
            //
            var cardHandler = new CardHandler();
            var player = new Player();
            var removedCard1 = cardHandler.RemoveCardFromDeck(shuffledDeck);
            cardHandler.AddCardToPlayersCards(removedCard1, player.playersCards);

            var removedCard2 = cardHandler.RemoveCardFromDeck(shuffledDeck);
            cardHandler.AddCardToPlayersCards(removedCard2, player.playersCards);

            //Print the cards that the user now has (look at magic year calcuclator to see how o seperate out logic and print to be able to test them properly
            //print the menu for playing



        }
    }
}




//handovernote: Sandy has suggested that I should focus on getting a working version where one player can play a game. And not worry about DRY or Single Responsibility for now.
//Once we have a working game for one player, we can look at DRY and Single repsonsibilit and how to group things into classes

 