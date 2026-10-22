using Lab.Managers.Spawn.Data;
using UnityEngine;

namespace Lab.Managers.Spawn.Services
{
    [CreateAssetMenu(fileName = "NewSpawnData", menuName = "Lab/Spawn/Base Spawn Data")]
    public class BaseSpawnService : SpawnService<SpawnData>
    {
    }
}