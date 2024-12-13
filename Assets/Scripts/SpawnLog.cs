using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLog : MonoBehaviour
{
    public GameObject[] Platforms;

    private float _platformSize;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            var position = collision.gameObject.transform.position + Vector3.right * _platformSize;
            var randomIdx = Random.Range(0, Platforms.Length);

            Instantiate(Platforms[randomIdx], position, Quaternion.identity);
        }
    }

    void Start()
    {
        var platform = Platforms[0].GetComponent<Platform>();
        _platformSize = platform.GetSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
