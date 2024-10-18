using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform objetivo;
    public int nivel;
    // Update is called once per frame
    void Update()
    {
        if(nivel==1)
        {
            if (objetivo.position.x > -0.7f && objetivo.position.x < 55f)
                transform.position = new Vector3(objetivo.position.x, transform.position.y, transform.position.z);
        }
        if (nivel == 2)
        {
            if (objetivo.position.x > -1f && objetivo.position.x < 51.7f)
                transform.position = new Vector3(objetivo.position.x, transform.position.y, transform.position.z);
        }
        if (nivel == 3)
        {
            if (objetivo.position.x > -1.9f && objetivo.position.x < 47.7f)
                transform.position = new Vector3(objetivo.position.x, transform.position.y, transform.position.z);
        }
        if (nivel == 4)
        {
            if (objetivo.position.x > -4.8f && objetivo.position.x < 51f)
                transform.position = new Vector3(objetivo.position.x, transform.position.y, transform.position.z);
        }
    }
}
