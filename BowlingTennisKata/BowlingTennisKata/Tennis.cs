using System;
using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapping;
        private readonly string _firstPlayer;
        private readonly string _secondPlayer;

        public Tennis(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;

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

        private string GetSameScore()
        {
            return IsFirstPlayerScoreHighThanThirty() ? "Deuce" : $"{_scoreMapping[_firstPlayerScore]}-All";
        }

        private string GetNormalScore()
        {
            return $"{_scoreMapping[_firstPlayerScore]}-{_scoreMapping[_secondPlayerScore]}";
        }

        private string GetWinOrAdvScore()
        {
            var distanceOfScore = _firstPlayerScore - _secondPlayerScore;
            return $"{(distanceOfScore > 0 ? _firstPlayer : _secondPlayer)} {(Math.Abs(distanceOfScore) > 1 ? "Win" : "Adv")}";
        }

        private bool IsWinOrAdv()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsFirstPlayerScoreHighThanThirty()
        {
            return _firstPlayerScore >= 3;
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
