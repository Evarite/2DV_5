using UnityEngine;

namespace Lab.Managers.Spawn
{
    public class SpawnContext
    {
        private readonly Transform _playerTransform;

        public SpawnContext(Transform playerTransform) => _playerTransform = playerTransform;

        public Transform PlayerTransform => _playerTransform;
    }
}