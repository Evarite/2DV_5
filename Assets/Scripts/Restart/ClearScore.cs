using Lab.Score;
using UnityEngine;
using VContainer;

namespace Lab.Restart
{
    public class ClearScore : MonoBehaviour
    {
        [Inject] private ScoreCounter _scoreCounter;

        public void Clear() => _scoreCounter.Score = 0;
    }
}