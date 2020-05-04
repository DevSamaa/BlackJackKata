using System;
namespace BlackJackKata
{
    public class Card
    {
        //properties - these are the things that each CardModel has.
        public string suit { get; set; }
        public string face { get; set; }
        public int points { get; set; }

        //constructor - these arguments must be passed in order for a new object to be created.
        public Card(string incomingSuit, string incomingFace, int incomingPoints)
        {
            suit = incomingSuit;
            face = incomingFace;
            points = incomingPoints;
        }
    }
}

