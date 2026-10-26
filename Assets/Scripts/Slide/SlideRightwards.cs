using Lab.Player.Death;
using UnityEngine;
using VContainer;

namespace Lab.Slide
{
    public class SlideRightwards : MonoBehaviour
    {
        [SerializeField] private float _speed = 2f;

        [Inject] private PlayerDeathHandler _playerDeathHandler;

        private void LateUpdate() => transform.position += Vector3.right * _speed * Time.deltaTime;

        private void OnEnable() => _playerDeathHandler.OnDeath += OnPlayerDied;

        private void OnDisable() => _playerDeathHandler.OnDeath -= OnPlayerDied;

        private void OnPlayerDied() => _speed = 0f;
    }
}