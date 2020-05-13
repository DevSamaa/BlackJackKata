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
            var allpoints = CalculatePoints();
            return allpoints < 17;
        }

        
    }
}
