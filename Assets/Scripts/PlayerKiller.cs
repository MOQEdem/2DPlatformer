using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _spawnPlace;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.GetComponent<Transform>().SetPositionAndRotation(_spawnPlace.position, Quaternion.identity);
        }
    }
}
