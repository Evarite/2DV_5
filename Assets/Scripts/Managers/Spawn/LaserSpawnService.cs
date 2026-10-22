using Lab.Pooling;
using UnityEngine;

namespace Lab.Managers.Spawn
{
    [CreateAssetMenu(fileName = "LaserSpawnService", menuName = "Lab/Spawn/Laser Spawn Service")]
    public class LaserSpawnService : SpawnService<LaserSpawnData>
    {
        protected override void SpawnEntity(PooledEntity entity, SpawnContext spawnContext)
        {
            base.SpawnEntity(entity, spawnContext);

            var entityTransform = entity.transform;

            float angle = Random.Range(spawnData.MinAngle, spawnData.MaxAngle);
            Quaternion rot = Quaternion.Euler(0f, 0f, angle);
            entityTransform.rotation = rot;

            float scale = Random.Range(spawnData.MinScaleY, spawnData.MaxScaleY);
            entityTransform.localScale = new(entityTransform.localScale.x, scale,
                entityTransform.localScale.z);
        }
    }
}