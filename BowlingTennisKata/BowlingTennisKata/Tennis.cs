namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore = 0;
        private int _secondPlayerScore = 0;

        public string Score()
        {
            if (_firstPlayerScore == 1 && _secondPlayerScore == 0)
            {
                return "Fifteen-Love";
            }
            
            if (_firstPlayerScore == 2 && _secondPlayerScore == 0)
            {
                return "Thirty-Love";
            }

            return "Love-All";
        }

        public void SetFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }
    }
}
