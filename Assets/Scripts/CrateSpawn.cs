using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawn : MonoBehaviour
{
    [SerializeField] private Crate _crate;

    private float _spawnTime;

    private void Start()
    {
        _spawnTime = 5f;
    }

    private void Update()
    {
        _spawnTime -= Time.deltaTime;

        if (_spawnTime <= 0)
        {
            Instantiate(_crate, gameObject.GetComponent<Transform>().position, Quaternion.identity);
            _spawnTime = 5f;
        }
    }
}
