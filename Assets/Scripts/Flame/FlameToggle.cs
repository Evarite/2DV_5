using Lab.Managers;
using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;

namespace Lab.Flame
{
    [RequireComponent(typeof(ParticleSystem))]
    public class FlameToggle : MonoBehaviour
    {
        [Inject] private InputManager _inputManager;

        private ParticleSystem _particleSystem;

        private void Awake()
        {
            _particleSystem = GetComponent<ParticleSystem>();

            _particleSystem.Stop(false, ParticleSystemStopBehavior.StopEmitting);
        }

        private void OnEnable()
        {
            _inputManager.InputActions.Player.Fly.performed += EnableFlame;
            _inputManager.InputActions.Player.Fly.canceled += DisableFlame;
        }

        private void OnDisable()
        {
            _inputManager.InputActions.Player.Fly.performed -= EnableFlame;
            _inputManager.InputActions.Player.Fly.canceled -= DisableFlame;
        }

        private void EnableFlame(InputAction.CallbackContext callbackContext) =>
            _particleSystem.Play();

        private void DisableFlame(InputAction.CallbackContext callbackContext) =>
            _particleSystem.Stop(false, ParticleSystemStopBehavior.StopEmitting);
    }
}