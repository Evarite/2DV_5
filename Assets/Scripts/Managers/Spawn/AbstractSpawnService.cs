using Lab.Pooling;
using UnityEngine;

namespace Lab.Managers.Spawn
{
    public abstract class AbstractSpawnService : ScriptableObject
    {
        public abstract void Spawn(PoolService poolService, SpawnContext spawnContext);
    }
}