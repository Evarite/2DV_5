using Lab.Managers;
using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;

namespace Lab.Controls
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class FlyControls : MonoBehaviour
    {
        [SerializeField] private float _flyForce = 3f;
        [SerializeField] private float _maxSpeed = 8f;

        [Inject] private InputManager _inputManager;

        private Rigidbody2D _rb;

        private float _flyValue = 0f;

        private void Awake() => _rb = GetComponent<Rigidbody2D>();

        private void OnEnable()
        {
            _inputManager.InputActions.Player.Fly.performed += OnFlyPerformed;
            _inputManager.InputActions.Player.Fly.canceled += OnFlyCancelled;
        }

        private void OnDisable()
        {
            _inputManager.InputActions.Player.Fly.performed -= OnFlyPerformed;
            _inputManager.InputActions.Player.Fly.canceled -= OnFlyCancelled;
        }

        private void FixedUpdate()
        {
            _rb.AddForceY(_flyForce * _flyValue);

            if (_rb.linearVelocityY * _rb.linearVelocityY >= _maxSpeed * _maxSpeed)
                _rb.linearVelocityY = _maxSpeed * Mathf.Sign(_rb.linearVelocityY);
        }

        private void OnFlyPerformed(InputAction.CallbackContext callbackContext) => _flyValue = 1f;

        private void OnFlyCancelled(InputAction.CallbackContext callbackContext) => _flyValue = 0f;
    }
}