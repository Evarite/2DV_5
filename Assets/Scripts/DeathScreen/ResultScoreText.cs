using Lab.Score;
using TMPro;
using UnityEngine;
using VContainer;

namespace Lab.DeathScreen
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ResultScoreText : MonoBehaviour
    {
        [Inject] private ScoreCounter _scoreCounter;

        private TextMeshProUGUI _text;

        private void Awake() => _text = GetComponent<TextMeshProUGUI>();

        private void OnEnable() => _text.text = _scoreCounter.Score.ToString();
    }
}