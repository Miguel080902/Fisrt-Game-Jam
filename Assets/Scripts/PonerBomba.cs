using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerBomba : MonoBehaviour
{
    public GameObject pressE;
    private GameObject player;
    private bool estaJugador = false;

    private void Update()
    {
        if (estaJugador && player != null)
        {
            player.GetComponent<Player>().ColocarBomba();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaJugador = true;
        if (collision.tag == "Player")
        {
            pressE.SetActive(true);
            player = collision.gameObject;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        estaJugador = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaJugador = false;
        if (collision.tag == "Player")
        {
            pressE.SetActive(false);
        }
    }
}
