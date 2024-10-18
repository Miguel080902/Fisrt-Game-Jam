using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEmmiter : MonoBehaviour
{
    public Transform listener; // Referencia al objeto que escucha el sonido
    private AudioSource audioSource;

    private void Start()
    {
        listener = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Calcula la distancia entre el emisor y el oyente
        float distance = Vector2.Distance(transform.position, listener.position);

        // Ajusta el volumen según la distancia
        audioSource.volume = 1f - Mathf.Clamp01(distance / 12);
    }
}
