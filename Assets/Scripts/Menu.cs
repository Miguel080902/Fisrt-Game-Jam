using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject inicio;
    public GameObject creditos;
    public void Jugar()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Creditos()
    {
        inicio.SetActive(false);
        creditos.SetActive(true);
    }
    public void Inicio()
    {
        inicio.SetActive(true);
        creditos.SetActive(false);
    }
}
