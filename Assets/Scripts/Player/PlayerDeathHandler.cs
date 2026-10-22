using System;
using UnityEngine;

namespace Lab.Player
{
    public class PlayerDeathHandler : MonoBehaviour
    {
        public event Action OnDeath;

        public void Die()
        {
            gameObject.SetActive(false);
            OnDeath?.Invoke();
        }
    }
}