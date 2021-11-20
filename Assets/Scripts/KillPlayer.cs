using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _spawnPlace;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Destroy(collision.gameObject);
            Instantiate(_player, _spawnPlace.position, Quaternion.identity);
        }
    }
}
