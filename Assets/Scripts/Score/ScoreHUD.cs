using TMPro;
using UnityEngine;
using VContainer;

namespace Lab.Score
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreHUD : MonoBehaviour
    {
        [Inject] private ScoreCounter _scoreCounter;

        private TextMeshProUGUI _text;

        private void Awake() => _text = GetComponent<TextMeshProUGUI>();

        private void OnEnable() => _scoreCounter.OnScoreChanged += OnScoreChanged;

        private void OnDisable() => _scoreCounter.OnScoreChanged -= OnScoreChanged;

        private void OnScoreChanged(int score) => _text.text = score.ToString();
    }
}