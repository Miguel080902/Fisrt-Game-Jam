using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private void Start()
    {
        // Obtén la cámara principal
        mainCamera = Camera.main;
    }
    void Update()
    {
        // Obtén la posición del mouse en pantalla
        Vector3 mousePositionScreen = Input.mousePosition;

        // Convierte la posición del mouse en pantalla a una posición en el mundo del juego
        transform.position = mainCamera.ScreenToWorldPoint(mousePositionScreen);

    }
}
