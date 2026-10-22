using UnityEngine;
using VContainer;

namespace Lab.Player.Triggers
{
    public class LaserTrigger : PlayerTriggerHandler
    {
        [Inject] private PlayerDeathHandler _deathHandler;

        protected override void HandleTriggerEnter(Collider2D collision) =>
            _deathHandler.Die();
    }
}