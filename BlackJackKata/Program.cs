using System;

namespace BlackJackKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackJack!");

            //TODO the next three lines could be put in a seperate DeckInitiator Class. 
            var deckCreator = new DeckCreator();
            var deckOfCards = deckCreator.CreateDeck();

            var deckShuffler = new DeckShuffler();
            var shuffledDeck = deckShuffler.ShuffleTheDeck(deckOfCards);

            var cardRemover = new CardRemover();
            var removedCards = cardRemover.RemoveCards2(shuffledDeck);


        }
    }
}
