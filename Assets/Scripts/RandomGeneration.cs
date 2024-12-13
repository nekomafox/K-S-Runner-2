using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGeneration : MonoBehaviour
{
    public GameObject[] _gameObject;
    void Start()
    {
        int rand = Random.Range(0, _gameObject.Length);
        Instantiate(_gameObject[rand], transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
