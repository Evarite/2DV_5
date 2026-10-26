using System;
using UnityEngine;

namespace Lab.Player.Death
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