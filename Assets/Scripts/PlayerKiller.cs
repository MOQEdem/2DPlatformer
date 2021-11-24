using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    [SerializeField] private Transform _spawnPlace;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.transform.SetPositionAndRotation(_spawnPlace.position, Quaternion.identity);
        }
    }
}
