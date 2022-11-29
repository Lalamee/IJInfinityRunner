using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemyPrefabs;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elpsedTime = 0;

    private void Update()
    {
        _elpsedTime += Time.deltaTime;

        if (_elpsedTime >= _secondBetweenSpawn)
        {
            _elpsedTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefabs, _spawnPoints[spawnPointNumber].position, Quaternion.identity);
        }
    }
}
