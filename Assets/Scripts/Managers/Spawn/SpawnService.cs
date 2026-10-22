using Lab.Pooling;
using UnityEngine;

namespace Lab.Managers.Spawn
{
    [CreateAssetMenu(menuName = "Lab/Spawn/Spawn Service", fileName = "NewSpawnService")]
    public class SpawnService<TSpawnData> : AbstractSpawnService
        where TSpawnData : SpawnData
    {
        [SerializeField] protected TSpawnData spawnData;

        public sealed override void Spawn(PoolService poolService, SpawnContext spawnContext)
        {
            for (int i = 0; i < spawnData.SpawnCount; i++)
                if (poolService.TryGet(spawnData.Prefab, out var entity))
                    SpawnEntity(entity, spawnContext);
        }

        protected virtual void SpawnEntity(PooledEntity entity, SpawnContext spawnContext)
        {
            float x = spawnContext.PlayerTransform.position.x +
                Random.Range(spawnData.MinXDist, spawnData.MaxXDist);
            float y = Random.Range(spawnData.MinY, spawnData.MaxY);

            entity.transform.position = new(x, y, 0f);
        }
    }
}