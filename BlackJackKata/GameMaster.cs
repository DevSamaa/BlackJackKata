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
    }
}
