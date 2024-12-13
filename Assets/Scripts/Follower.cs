using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform Player;


    void Start()
    {
        
    }
    void LateUpdate()
    {
        transform.position = new Vector2 (Player.position.x, transform.position.y);
        
    }
}
