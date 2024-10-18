using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    [SerializeField] private float velocidad;
    private Vector2 direccion;
    //private Rigidbody2D rb2D;
    private Vector2 input;
    public GameObject flashlight;
    public bool activar = false;
    public float bateria;
    const float BATERIA_MAX=15f;
    public Slider slider;
    public int vida=5;
    public AudioClip linterna1;
    public AudioClip linterna2;
    public AudioClip paso1;
    public AudioClip paso2;
    public AudioClip danio1;
    public AudioClip danio2;
    bool danioUno = true;
    bool pasoUno = true;
    float contPasos=0.5f;
    public Animator anim;
    public Animator panelTransicion;
    public bool tieneBomba;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
        bateria = BATERIA_MAX;
        slider.maxValue = bateria;
        slider.value = bateria;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && bateria>0) // Presionar botón izquierdo del mouse para activar/desactivar la linterna
        {
            activar = !activar;
            if(activar)
            {
                SoundManager.instance.EjecutarSonido(linterna1);
            }
            else
            {
                SoundManager.instance.EjecutarSonido(linterna2);
            }
        }
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        direccion = input.normalized;
        flashlight.SetActive(activar);
        RestarBateria();
    }

    private void FixedUpdate()
    {
        if(input == Vector2.zero)
        {
            anim.SetFloat("velocidad", 0f);
            //rb2D.velocity = Vector2.zero;
        }else
        {
            anim.SetFloat("velocidad", 1f);
            contPasos += Time.deltaTime;
            if(contPasos>=0.3f)
            {
                if(pasoUno)
                {
                    SoundManager.instance.EjecutarSonido(paso1);
                    pasoUno = !pasoUno;
                }else
                {
                    SoundManager.instance.EjecutarSonido(paso2);
                }
                contPasos = 0;
            }
            
            //rb2D.MovePosition(rb2D.position + direccion * velocidad * Time.fixedDeltaTime);
            transform.position = new Vector3(transform.position.x + direccion.x * velocidad * Time.fixedDeltaTime, transform.position.y + direccion.y * velocidad * Time.fixedDeltaTime, transform.position.z);
        }
    }

    public void CargarBateria()
    {
        bateria = BATERIA_MAX;
        slider.value = bateria;
    }

    public void RestarBateria()
    {
        if(activar)
        {
            bateria -= Time.deltaTime;
            slider.value = bateria;
            if(bateria<=0)
            {
                activar = false;
            }
        }
    }

    public void RestarVida()
    {
        if(danioUno)
        {
            SoundManager.instance.EjecutarSonido(danio1);
        }else
        {
            SoundManager.instance.EjecutarSonido(danio2);
        }
        danioUno = !danioUno;
        vida -= 1;
        if(vida==4)
        {
            panel1.SetActive(true);
        }
        if (vida == 3)
        {
            panel2.SetActive(true);
            panel1.SetActive(false);
        }
        if (vida == 2)
        {
            panel3.SetActive(true);
            panel2.SetActive(false);
        }
        if (vida == 1)
        {
            panel4.SetActive(true);
            panel3.SetActive(false);
        }
        if (vida<=0)
        {
            string nombreEscenaActual = SceneManager.GetActiveScene().name;

            // Recarga la escena actual utilizando su nombre
            SceneManager.LoadScene(nombreEscenaActual);
        }
    }

    public void RecogerBomba(GameObject bomba)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            tieneBomba = true;
            Destroy(bomba);
        }
    }
    public void ColocarBomba()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            panelTransicion.SetFloat("activar", 1f);
        }
    }
}
