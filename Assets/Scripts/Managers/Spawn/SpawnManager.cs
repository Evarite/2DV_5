using Lab.Managers.Spawn.Services;
using Lab.Pooling;
using System.Collections;
using UnityEngine;
using VContainer;

namespace Lab.Managers.Spawn
{
    public class SpawnManager : MonoBehaviour
    {
        [Header("Spawn Service")]
        [SerializeField] private AbstractSpawnService[] _spawnServices;

        [Header("Time")]
        [SerializeField] private float _spawnCooldownTime = 3f;

        [Inject] private SpawnContext _spawnContext;
        [Inject] private PoolService _poolService;

        private WaitForSeconds _spawnCooldown;

        private void Awake() => _spawnCooldown = new(_spawnCooldownTime);

        private void OnEnable() => StartCoroutine(Spawn());

        private void OnDisable() => StopAllCoroutines();

        private IEnumerator Spawn()
        {
            while (true)
            {
                yield return _spawnCooldown;

                foreach (var service in _spawnServices)
                    service.Spawn(_poolService, _spawnContext);
            }
        }
    }
}