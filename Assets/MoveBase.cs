using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBase : MonoBehaviour
{
    [SerializeField] private BaseSpawn _baseSpawner = default;
    

    void Start()
    {
        _baseSpawner = GetComponent<BaseSpawn>();
    }
    

    // Update is called once per frame
    public void SpawnTriggerEntered()
    {
        _baseSpawner.MoveBase();
    }
}
