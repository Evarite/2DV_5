using UnityEngine;

namespace Lab.Player.Triggers
{
    [RequireComponent(typeof(Collider2D))]
    public abstract class PlayerTriggerHandler : MonoBehaviour
    {
        private void Awake() => GetComponent<Collider2D>().isTrigger = true;

        private void OnTriggerEnter2D(Collider2D collision) => HandleTriggerEnter(collision);

        protected abstract void HandleTriggerEnter(Collider2D collision);
    }
}