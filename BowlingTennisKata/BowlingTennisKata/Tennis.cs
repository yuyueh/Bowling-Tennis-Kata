using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private readonly Dictionary<int, string> _scoreMapper;
        private string _firstPlayer;
        private string _secondPlayer;

        public Tennis(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;

            _scoreMapper = new Dictionary<int, string>()
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };
        }

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (_firstPlayerScore >= 3 && _secondPlayerScore >= 3)
                {
                    if (_firstPlayerScore - _secondPlayerScore == 1)
                    {
                        return _firstPlayer + " Adv";
                    }
                    if (_firstPlayerScore - _secondPlayerScore == 2)
                    {
                        return _firstPlayer + " Win";
                    }
                }

                return _scoreMapper[_firstPlayerScore] + "-" + _scoreMapper[_secondPlayerScore];
            }

            if (_firstPlayerScore >= 3)
            {
                return "Deuce";
            }

            return _scoreMapper[_firstPlayerScore] + "-All";
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
