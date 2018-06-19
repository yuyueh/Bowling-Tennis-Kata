﻿using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore = 0;
        private int _secondPlayerScore = 0;
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

            if (_firstPlayerScore != _secondPlayerScore)
            {
                return _scoreMapping[_firstPlayerScore] + "-" + _scoreMapping[_secondPlayerScore];
            }

            return "Love-All";
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
