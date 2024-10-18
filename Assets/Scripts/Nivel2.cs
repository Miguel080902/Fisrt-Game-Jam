using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nivel2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int numero = SceneManager.GetActiveScene().buildIndex;
        if (collision.tag=="Player")
        {
            if(numero==1)
            {
                if(collision.GetComponent<Player>().tieneBomba)
                {
                    CargarSiguienteEscena();
                }
            }
            else
            {
                CargarSiguienteEscena();
            }
        }
    }
    public void CargarSiguienteEscena()
    {
        // Obt�n el �ndice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Carga la siguiente escena sumando 1 al �ndice
        SceneManager.LoadScene(indiceEscenaActual + 1);
    }
}
