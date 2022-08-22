using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BaseSpawn : MonoBehaviour
{
    [SerializeField]private List<GameObject> _allBase;
     private float _offset = 20;

    void Start()
    {
    if (_allBase != null && _allBase.Count > 0)
        {
            _allBase = _allBase.OrderBy(n => n.transform.position.z).ToList();
        }
    }

    // Update is called once per frame
    public void MoveBase()
    {
        GameObject movedBase = _allBase[0];
        _allBase.Remove(movedBase);
        float newz = _allBase[_allBase.Count - 1].transform.position.z + _offset;
        movedBase.transform.position = new Vector3(0, 0, newz);
        _allBase.Add(movedBase);
    }
}
