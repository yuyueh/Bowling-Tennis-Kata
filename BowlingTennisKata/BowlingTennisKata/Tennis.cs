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
            return IsSameScore() ? GetDecueOrSameScore() : IsWinOrAdvScore() ? GetWinOrAdvScore() : GetNormalScore();
        }

        private string GetNormalScore()
        {
            return _scoreMapping[_firstPlayerScore] + "-" + _scoreMapping[_secondPlayerScore];
        }

        private string GetWinOrAdvScore()
        {
            var distanceOfScore = _firstPlayerScore - _secondPlayerScore;
            return GetWinnerNameByDistanceOfScore(distanceOfScore) + (IsWinning(distanceOfScore) ? " Win" : " Adv");
        }

        private string GetDecueOrSameScore()
        {
            return IsFirstPlayerScoreHighThanThirty() ? "Deuce" : _scoreMapping[_firstPlayerScore] + "-All";
        }

        private bool IsWinning(int distanceOfScore)
        {
            return Math.Abs(distanceOfScore) > 1;
        }

        private string GetWinnerNameByDistanceOfScore(int distanceOfScore)
        {
            return distanceOfScore > 0 ? _firstPlayer : _secondPlayer;
        }

        private bool IsFirstPlayerScoreHighThanThirty()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsWinOrAdvScore()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
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
