using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    [SerializeField] private Transform objetivo;
    void Update()
    {
        if (objetivo == null)
        {
            if (transform.childCount > 0)
                objetivo = transform.GetChild(0).gameObject.GetComponent<verJugador>().playerMove;
        }
        if (objetivo!=null)
        {
            float anguloRadianes = Mathf.Atan2(objetivo.position.y - transform.position.y, objetivo.position.x - transform.position.x);
            float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
            transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
        }       
    }
}
