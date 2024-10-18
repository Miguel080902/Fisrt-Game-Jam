using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public AudioClip recolectar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            SoundManager.instance.EjecutarSonido(recolectar);
            collision.GetComponent<Player>().CargarBateria();
            gameObject.SetActive(false);
            Invoke("destruir", 1f);

        }
    }
    private void destruir()
    {
        Destroy(gameObject);
    }
}
