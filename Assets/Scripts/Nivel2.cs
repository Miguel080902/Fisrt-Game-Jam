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
        // Obtén el índice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Carga la siguiente escena sumando 1 al índice
        SceneManager.LoadScene(indiceEscenaActual + 1);
    }
}
