using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IrFinal : MonoBehaviour
{
    public void CargarSiguienteEscena()
    {
        // Obtén el índice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Carga la siguiente escena sumando 1 al índice
        SceneManager.LoadScene(indiceEscenaActual + 1);
    }
}
