using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    [SerializeField] private Crate _crate;
    [SerializeField] private float _spawnTime;

    private void Start()
    {
        StartCoroutine(Spawn(_spawnTime));
    }

    private IEnumerator Spawn(float spawnTime)
    {
        var waitingTime = new WaitForSeconds(spawnTime);

        while (true)
        {
            Instantiate(_crate, transform.position, Quaternion.identity);
            yield return waitingTime;
        }
    }
}
