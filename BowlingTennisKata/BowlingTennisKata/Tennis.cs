namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen-Love";
            }
            return "Love-All";
        }

        public void GivenFirstPlayerScore(int score)
        {
            _firstPlayerScore = score;
        }
    }
}
