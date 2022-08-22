using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints = default;
    [SerializeField] private GameObject _enemyPrefab = default;
    private int _speed = 8;

    void Start()
    {
        InvokeRepeating(nameof(SpawnNewEnemy), 1, 2);    
    }

    // Update is called once per frame
    void SpawnNewEnemy()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, _spawnPoints.Length - 1));
        Instantiate(_enemyPrefab, _spawnPoints[randomNumber].transform.position,_spawnPoints[randomNumber].transform.rotation);
        
    }
}
