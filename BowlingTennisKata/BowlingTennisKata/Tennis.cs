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

            return "Love-All";
        }

        public void SetOnePlayerScore(int score)
        {
            _firstPlayerScore = score;
        }
    }
}
