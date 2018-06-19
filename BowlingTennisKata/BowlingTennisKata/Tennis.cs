using System;
using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapping;
        private readonly Dictionary<int, string> _scoreCompareMapping;
        private readonly string _firstPlayer;
        private readonly string _secondPlayer;

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
            if (_firstPlayerScore == _secondPlayerScore)
            {
                return _firstPlayerScore >= 3 ? "Deuce" : _scoreMapping[_firstPlayerScore] + "-All";
            }

            if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
            {
                var compare = _firstPlayerScore - _secondPlayerScore;

                if (Math.Abs(compare) > 1)
                {
                    return (compare > 0 ? _firstPlayer : _secondPlayer) + " Win";
                }
                
                return (compare > 0 ? _firstPlayer : _secondPlayer) + " Adv";
            }

            return _scoreMapping[_firstPlayerScore] + "-" + _scoreMapping[_secondPlayerScore];
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
