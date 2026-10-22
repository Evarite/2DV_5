using UnityEngine;

namespace Lab.Pooling
{
    public class EntityReturnOnCameraExit : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<PooledEntity>(out var entity))
                entity.Return();
        }
    }
}