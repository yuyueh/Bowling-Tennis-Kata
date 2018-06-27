using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;
        private readonly Dictionary<int, string> _scoreMapper;

        public Tennis(string firstPlayer, string secondPlayer)
        {
            _scoreMapper = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };
        }

        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return _scoreMapper[_firstPlayerScore] + "-Love";
            }

            return "Love-All";
        }

        public void GivenFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }
    }
}
