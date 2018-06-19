using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private string _firstPlayer;
        private string _secondPlayer;
        private readonly Dictionary<int, string> _scoreMapping;

        public Tennis(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;

            _firstPlayerScore = 0;
            _secondPlayerScore = 0;
            _scoreMapping = new Dictionary<int, string>()
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };
        }

        public string Score()
        {
            if (_firstPlayerScore >= 3 && _secondPlayerScore >= 3)
            {
                if (_firstPlayerScore == _secondPlayerScore)
                {
                    return "Deuce";
                }

                if (_firstPlayerScore - _secondPlayerScore > 1)
                {
                    return _firstPlayer + " Win";
                }
                else
                {
                    return _firstPlayer + " Adv";
                }
            }
            
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return _scoreMapping[_firstPlayerScore] + "-" + _scoreMapping[_secondPlayerScore];
            }

            return _scoreMapping[_firstPlayerScore] + "-All";
        }

        public void SetFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }

        public void SetSecondPlayerScore(int score)
        {
            _secondPlayerScore = score;
        }
    }
}
