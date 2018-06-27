using System;
using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapper;
        private readonly string _firstPlayer;
        private readonly string _secondPlayer;

        public Tennis(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;

            _scoreMapper = new Dictionary<int, string>()
            {
                { 0, "Love" },
                { 1, "Fifteen" },
                { 2, "Thirty" },
                { 3, "Forty" },
            };
        }

        public string Score()
        {
            return IsSameScore() ? GetSameScore() : IsAdvOrWin() ? GetAdvOrWinScore() : GetNormalScore();
        }

        public void GivenFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }

        public void GivenSecondPlayerScore(int score)
        {
            _secondPlayerScore = score;
        }

        private string GetAdvOrWinScore()
        {
            var higherPlayer = _firstPlayerScore > _secondPlayerScore ? _firstPlayer : _secondPlayer;
            var result = Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1 ? " Adv" : " Win";
            return higherPlayer + result;
        }

        private string GetSameScore()
        {
            return IsDeuce() ? "Deuce" : _scoreMapper[_firstPlayerScore] + "-All";
        }

        private string GetNormalScore()
        {
            return _scoreMapper[_firstPlayerScore] + "-" + _scoreMapper[_secondPlayerScore];
        }

        private bool IsAdvOrWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }
    }
}
