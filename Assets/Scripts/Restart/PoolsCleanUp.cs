using Lab.Pooling;
using UnityEngine;
using VContainer;

namespace Lab.Restart
{
    public class PoolsCleanUp : MonoBehaviour
    {
        [Inject] private PoolService _poolService;

        public void CleanUp() => _poolService.ReturnAll();
    }
}