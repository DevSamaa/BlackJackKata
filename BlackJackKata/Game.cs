using System;
namespace BlackJackKata
{
    public class Game
    {
        private GameMaster _gameMaster;
        private EndOfGame _endOfGame;
        private Human _human;
        private Dealer _dealer;

        public Game(GameMaster gameMaster = null, EndOfGame endOfGame = null, Human human = null, Dealer dealer = null)
        {
            _gameMaster = gameMaster ?? new GameMaster();
            _endOfGame = endOfGame ?? new EndOfGame();
            _human = human ?? new Human();
            _dealer = dealer ?? new Dealer();
        }

        public void Run()
            {
            Console.WriteLine("Welcome to BlackJack!");

            _gameMaster.PlayHand(_human);
            if (_human.IsBust())
            {
                Console.WriteLine("Dealer wins");
                return;
            }
            Console.WriteLine("You're turn is over, the dealers turn begins \n");

            _gameMaster.PlayHand(_dealer);
            if (_dealer.IsBust())
            {
                Console.WriteLine("Human wins");
                return;
            }

            var humanScore = _human.CalculatePoints();
            var dealerScore = _dealer.CalculatePoints();

            var winnerIs =  _endOfGame.FindWinnner(humanScore, dealerScore);
            Console.WriteLine(winnerIs);


        }
    }
}
