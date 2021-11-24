using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    [SerializeField] private Crate _crate;
    [SerializeField] private float _timeToSpawn;

    private void Start()
    {
        StartCoroutine(Spawn(_timeToSpawn));
    }

    private IEnumerator Spawn(float timeToSpawn)
    {
        var waitingTime = new WaitForSeconds(timeToSpawn);

        while (true)
        {
            Instantiate(_crate, transform.position, Quaternion.identity);
            yield return waitingTime;
        }
    }
}
