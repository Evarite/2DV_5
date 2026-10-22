using System;
using UnityEngine;

namespace Lab.Player
{
    public class PlayerReviveHandler : MonoBehaviour
    {
        public event Action OnRevived;

        public void Revive() => OnRevived?.Invoke();
    }
}