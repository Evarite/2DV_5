using Lab.Score;
using UnityEngine;
using VContainer;

namespace Lab.Player.Triggers
{
    public class CoinTrigger : PlayerTriggerHandler
    {
        [Inject] private ScoreCounter _scoreCounter;

        protected override void HandleTriggerEnter(Collider2D collision)
            => _scoreCounter.Score++;
    }
}