using System;
using System.Collections.Generic;

namespace BlackJackKata
{
    public class GameMaster
    {
        public GameMaster()
        {
        }

        public void dealInitialCards(CardHandler cardHandler, List<Card> shuffledDeck, Player player)
        {
            var removedCard1 = cardHandler.RemoveCardFromDeck(shuffledDeck);
            cardHandler.AddCardToPlayersCards(removedCard1, player.playersCards);

            var removedCard2 = cardHandler.RemoveCardFromDeck(shuffledDeck);
            cardHandler.AddCardToPlayersCards(removedCard2, player.playersCards);
        }


        public int showCardsAndPoints(Player player)
        {
            var playersPoints = player.CalculatePoints();
            player.ShowPoints(playersPoints);
            player.ShowCards();
            return playersPoints;
        }

        public void playGame(Player player, CardHandler cardHandler, List<Card> shuffledDeck)
        {
            while (true)
            {
                // Calculate points and show them to everyone
                var playersPoints = showCardsAndPoints(player);

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
                if (playersPoints > 21)
                {
                    player.ShowPoints(playersPoints);
                    player.ShowCards();
                    Console.WriteLine("You have gone bust. You lose. Game Over.");
                    return;
                }

            }
        }
    }
}
