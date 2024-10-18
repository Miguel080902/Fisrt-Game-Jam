using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IrFinal : MonoBehaviour
{
    public void CargarSiguienteEscena()
    {
        // Obt�n el �ndice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Carga la siguiente escena sumando 1 al �ndice
        SceneManager.LoadScene(indiceEscenaActual + 1);
    }
}
