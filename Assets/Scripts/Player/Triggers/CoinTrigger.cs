using Lab.Pooling;
using Lab.Score;
using UnityEngine;
using VContainer;

namespace Lab.Player.Triggers
{
    public class CoinTrigger : PlayerTriggerHandler
    {
        [Inject] private ScoreCounter _scoreCounter;

        protected override void HandleTriggerEnter(Collider2D collision)
        {
            if (collision.TryGetComponent<PooledEntity>(out var entity))
            {
                _scoreCounter.Score++;
                entity.Return();
            }
        }
    }
}