using System;

namespace BlackJackKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var deckCreator = new DeckCreator();

            var deckOfCards = deckCreator.CreateDeck();
        }
    }
}
