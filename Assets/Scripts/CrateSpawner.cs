using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    [SerializeField] private Crate _crate;
    [SerializeField] private float _spawnTime;

    private void Start()
    {
        StartCoroutine(SpawnCrate(_spawnTime));
    }

    private IEnumerator SpawnCrate(float spawnTime)
    {
        while (true)
        {
            Instantiate(_crate, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
