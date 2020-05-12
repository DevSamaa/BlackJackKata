using System;
namespace BlackJackKata
{
    public class Dealer : Player
    {
        public Dealer()
        {
        }

        public override bool WantsToHit()
        {
            int allpoints = 0;
            foreach (var card in playersCards)
            {
               allpoints = allpoints + card.points;
            }

            if (allpoints < 17)
            {
             return true;
            }
            return false;

        }
    }
}
