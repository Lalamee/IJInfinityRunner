using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject _enemyPrefabs;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elpsedTime = 0;

    private void Start()
    {
        Initialize(_enemyPrefabs);
    }
    
    private void Update()
    {
        _elpsedTime += Time.deltaTime;

        if (_elpsedTime >= _secondBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elpsedTime = 0;
                
                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
            }
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
