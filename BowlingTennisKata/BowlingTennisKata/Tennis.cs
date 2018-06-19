using System;
using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private Dictionary<int, string> _scoreMapping;
        private string _firstPlayerName;
        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;

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
                if (_firstPlayerScore >= 3)
                {
                    return "Deuce";
                }

                return $"{_scoreMapping[_firstPlayerScore]}-All";
            }

            if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
            {
                var differenceOfScore = _firstPlayerScore - _secondPlayerScore;
                return $"{(differenceOfScore > 0 ? _firstPlayerName : _secondPlayerName)} {(Math.Abs(differenceOfScore) > 1 ? "Win" : "Adv")}";
            }

            return $"{_scoreMapping[_firstPlayerScore]}-{_scoreMapping[_secondPlayerScore]}";
        }

        public void GivenFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }

        public void GivenSecondPlayerScore(int score)
        {
            _secondPlayerScore = score;
        }
    }
}
