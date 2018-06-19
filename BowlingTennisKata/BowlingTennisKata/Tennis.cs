using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private Dictionary<int, string> _scoreMapping;

        public Tennis()
        {
            _scoreMapping = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            };
        }

        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return $"{_scoreMapping[_firstPlayerScore]}-Love";
            }

            return "Love-All";
        }

        public void GivenFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }

        public void GivenSecondPlayerScore(int score)
        {
            throw new System.NotImplementedException();
        }
    }
}
