using DG.Tweening;
using Lab.Player.Death;
using UnityEngine;

namespace Lab.DeathScreen
{
    public class DeathScreenToggle : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _deathScreen;
        [SerializeField] private float _fadeTime = 1f;
        [SerializeField] private PlayerDeathHandler _deathHandler;

        private float _maxOpacity = 1f;
        private float _minOpacity = 0f;

        private void OnEnable() => _deathHandler.OnDeath += ActivateDeathScreen;

        private void OnDisable() => _deathHandler.OnDeath -= ActivateDeathScreen;

        private void ActivateDeathScreen()
        {
            _deathScreen.gameObject.SetActive(true);
            _deathScreen.DOFade(_maxOpacity, _fadeTime);
        }

        public void DeactivateDeathScreen()
        {
            _deathScreen.alpha = _minOpacity;
            _deathScreen.gameObject.SetActive(false);
        }
    }
}