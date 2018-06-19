using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapping;
        private readonly Dictionary<int, string> _scoreCompareMapping;

        public Tennis(string firstPlayer, string secondPlayer)
        {
            _firstPlayerScore = 0;
            _secondPlayerScore = 0;
            _scoreMapping = new Dictionary<int, string>()
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };

            _scoreCompareMapping = new Dictionary<int, string>()
            {
                {0, "Deuce"},
                {1, firstPlayer + " Adv"},
                {2, firstPlayer + " Win"}
            };
        }

        public string Score()
        {
            if (_firstPlayerScore >= 3 && _secondPlayerScore >= 3)
            {
                return _scoreCompareMapping[_firstPlayerScore - _secondPlayerScore];
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
