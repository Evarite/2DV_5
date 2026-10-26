using UnityEngine;

namespace Lab.Restart
{
    public class RevivePlayer : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private Vector3 _spawnPosition;

        public void Respawn()
        {
            _player.SetActive(true);
            _player.transform.localPosition = _spawnPosition;
        }
    }
}