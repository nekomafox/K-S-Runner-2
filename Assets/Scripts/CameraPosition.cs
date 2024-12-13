using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform Player;
    public bool playerBool;


    //private void Update()
    //{
    //    transform.position = new Vector3(Player.transform.position.x,transform.position.y,transform.position.z);
        
    //}

    private void FixedUpdate()
    {
        if (playerBool == true) 
        { 
            transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z); 
        }
        

    }
}
