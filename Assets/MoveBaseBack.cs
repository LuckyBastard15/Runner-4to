using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveBaseBack : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.back);
    }
}
