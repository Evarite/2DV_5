using UnityEngine;

namespace Lab.Slide
{
    public class SlideRightwards : MonoBehaviour
    {
        [SerializeField] private float _speed = 2f;

        private void LateUpdate() => transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}