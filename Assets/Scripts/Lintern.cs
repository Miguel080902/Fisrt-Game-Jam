using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lintern : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().RecibirDaño();
        }
    }
    
}
