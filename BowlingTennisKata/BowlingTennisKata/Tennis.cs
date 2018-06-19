using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private Dictionary<int, string> _scoreMapping;

        public Tennis()
        {
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
            if (_firstPlayerScore > 0 || _secondPlayerScore > 0)
            {
                return $"{_scoreMapping[_firstPlayerScore]}-{_scoreMapping[_secondPlayerScore]}";
            }

            return "Love-All";
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
