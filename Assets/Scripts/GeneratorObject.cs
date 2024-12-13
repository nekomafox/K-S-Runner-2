
using UnityEngine;

public class GeneratorObject : MonoBehaviour

{
    public GameObject[] _gameObject;
    void Start()
    {
        int rand = Random.Range(0, _gameObject.Length);
        Instantiate(_gameObject[rand], transform.position, Quaternion.identity);
    }

    void CreateObjects()
    {
  
        
    }

    /*private void Instantiate()
    {
        throw new NotImplementedException();
    }*/
}
