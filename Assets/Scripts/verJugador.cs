using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verJugador : MonoBehaviour
{
    public Transform playerMove;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            playerMove=collision.GetComponent<Transform>();
            Destroy(gameObject,2f);
        }
    }
}
