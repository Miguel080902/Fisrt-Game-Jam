using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float velocidad = 2;
    [SerializeField] private float vida=2;
    public enum TipoEnemigo
    {
        murcielago,
        monstruo
    }
    public Transform player;
    public TipoEnemigo tipoEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null)
        {
            if(player.position.x<transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            Vector2 direccion = player.position - transform.position;
            transform.position += (Vector3)direccion.normalized * velocidad * Time.deltaTime;
        }else
        {
            if(transform.childCount>0)
            player = transform.GetChild(0).gameObject.GetComponent<verJugador>().playerMove;
        }
    }

    public void RecibirDaño()
    {
        if(player!=null)
        {
            vida -= Time.deltaTime;
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Vector2 direccion = player.position - transform.position;
            if(tipoEnemigo==TipoEnemigo.murcielago)
            {
                collision.gameObject.GetComponent<Player>().RestarVida();
                transform.position -= (Vector3)direccion.normalized * 1.3f;
            }
            else
            {
                collision.gameObject.GetComponent<Player>().RestarVida();
                transform.position -= (Vector3)direccion.normalized * 0.5f;
            }   
        }
    }
}
