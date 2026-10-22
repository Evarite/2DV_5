using Lab.Pooling;
using UnityEngine;

namespace Lab.Managers.Spawn.Data
{
    [System.Serializable]
    public class SpawnData
    {
        [Header("Prefab")]
        [SerializeField] private PooledEntity _prefab;

        [Header("Count")]
        [SerializeField] private int _spawnCount = 3;

        [Header("Coordinates")]
        [SerializeField] private float _minY = -4f;
        [SerializeField] private float _maxY = 4f;
        [SerializeField] private float _minXDist = 10f;
        [SerializeField] private float _maxXDist = 30f;

        public PooledEntity Prefab => _prefab;
        public int SpawnCount => _spawnCount;
        public float MinY => _minY;
        public float MaxY => _maxY;
        public float MinXDist => _minXDist;
        public float MaxXDist => _maxXDist;
    }
}