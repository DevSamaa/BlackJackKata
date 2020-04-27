using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackKata
{
    public class DeckShuffler
    {
        public DeckShuffler()
        {
        }

        public List<CardModel> ShuffleTheDeck(List<CardModel> incomingCards)
        {
            var shuffledDeck = incomingCards.OrderBy(x => Guid.NewGuid()).ToList();
            return shuffledDeck;
        }
        
    }
}

