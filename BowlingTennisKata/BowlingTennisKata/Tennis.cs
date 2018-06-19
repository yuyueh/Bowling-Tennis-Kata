using System;
using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapping;
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;

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
            return IsSameScore() ? GetSameScore() : IsWinOrAdv() ? GetWinOrAdvScore() : GetNormalScore();
        }

        private string GetNormalScore()
        {
            return $"{_scoreMapping[_firstPlayerScore]}-{_scoreMapping[_secondPlayerScore]}";
        }

        private string GetWinOrAdvScore()
        {
            var differenceOfScore = _firstPlayerScore - _secondPlayerScore;
            return $"{(differenceOfScore > 0 ? _firstPlayerName : _secondPlayerName)} {(Math.Abs(differenceOfScore) > 1 ? "Win" : "Adv")}";
        }

        private string GetSameScore()
        {
            return _firstPlayerScore >= 3 ? "Deuce" : $"{_scoreMapping[_firstPlayerScore]}-All";
        }

        private bool IsWinOrAdv()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
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
