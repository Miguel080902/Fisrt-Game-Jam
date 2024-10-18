using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private void Start()
    {
        // Obt�n la c�mara principal
        mainCamera = Camera.main;
    }
    void Update()
    {
        // Obt�n la posici�n del mouse en pantalla
        Vector3 mousePositionScreen = Input.mousePosition;

        // Convierte la posici�n del mouse en pantalla a una posici�n en el mundo del juego
        transform.position = mainCamera.ScreenToWorldPoint(mousePositionScreen);

    }
}
