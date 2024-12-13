using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLog : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(collision.gameObject);
        }
    }
}
