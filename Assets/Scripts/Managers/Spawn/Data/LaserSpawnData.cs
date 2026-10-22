using UnityEngine;

namespace Lab.Managers.Spawn.Data
{
    [System.Serializable]
    public class LaserSpawnData : SpawnData
    {
        [Header("Laser Data")]
        [SerializeField] private float _minAngle = -90f;
        [SerializeField] private float _maxAngle = 90f;
        [SerializeField] private float _minScaleY = 1f;
        [SerializeField] private float _maxScaleY = 4f;

        public float MinAngle => _minAngle;
        public float MaxAngle => _maxAngle;
        public float MinScaleY => _minScaleY;
        public float MaxScaleY => _maxScaleY;
    }
}