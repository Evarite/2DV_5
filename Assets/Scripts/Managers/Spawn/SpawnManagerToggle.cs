using Lab.Player.Death;
using UnityEngine;
using VContainer;

namespace Lab.Managers.Spawn
{
    public class SpawnManagerToggle : MonoBehaviour
    {
        [SerializeField] private SpawnManager _spawnManager;

        [Inject] private PlayerDeathHandler _playerDeathHandler;

        private void OnEnable()
        {
            _playerDeathHandler.OnDeath += DisableSpawnManager;
        }

        private void OnDisable()
        {
            _playerDeathHandler.OnDeath -= DisableSpawnManager;
        }

        private void DisableSpawnManager() => _spawnManager.enabled = false;
    }
}