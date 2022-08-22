using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColBase : MonoBehaviour
{
    [SerializeField] private MoveBase _duplicateBase = null;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SpawnTigger"))
        {
            _duplicateBase.SpawnTriggerEntered();
        }
    }
}
