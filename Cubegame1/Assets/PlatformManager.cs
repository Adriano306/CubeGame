using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _platformPrefabs;
    [SerializeField]
    private int _zedOffset;
    

    void Start()
    {
        for(int i = 0; i < _platformPrefabs.Length; i++)
        {
            Instantiate(_platformPrefabs[i], new Vector3(0, 0, i * 100), Quaternion.Euler(0, 0, 0));
            _zedOffset += 100;
        }
        
    }

    public void  RecyclePlatform(GameObject platform)
    {
        platform.transform.position = new Vector3(0, 0, _zedOffset);
        _zedOffset += 100;
    }
}
