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


            while (true)
            {
                // Calculate points and show them to everyone
                var playersPoints = player.CalculatePoints();
                player.ShowPoints(playersPoints);
                player.ShowCards();

                //Get UserInput (Hit or Stay)
                var userInput = new UserInput();

                int validatedNumber;

                while (true)
                {

                    try
                    {
                        var savedUserInput = userInput.UserPrompt();

                        validatedNumber = userInput.ValidateNumber(savedUserInput);

                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                //if they selected hit this should happen
                if (validatedNumber == 1)
                {
                    var removedCard3 = cardHandler.RemoveCardFromDeck(shuffledDeck);
                    cardHandler.AddCardToPlayersCards(removedCard3, player.playersCards);
                    playersPoints = player.CalculatePoints();
                }
                else
                {
                    break;
                }

                // "checkIfBust" method
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




//handovernote: Sandy has suggested that I should focus on getting a working version where one player can play a game. And not worry about DRY or Single Responsibility for now.
//Once we have a working game for one player, we can look at DRY and Single repsonsibilit and how to group things into classes

 