using System;

namespace Lab.Score
{
    public class ScoreCounter
    {
        private int _score = 0;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                OnScoreChanged?.Invoke(_score);
            }
        }

        public event Action<int> OnScoreChanged;
    }
}