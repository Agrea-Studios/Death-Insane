using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladormove : MonoBehaviour
{
    //variables para valores predeterminados para la velocidad y lo movible

    private Rigidbody2D xdxd;
    public float maxspeed = 5f;
    public float speed = 2f;
    public bool TKSL;
    public float FDsalto = 6.5f;
    private bool salto;
    private Rigidbody2D rb2d;
    private Animator anima;
    public bool movement = true;
    public bool despl;
    public bool despl2;
    public bool Exd;
    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        xdxd = GetComponent<Rigidbody2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {



        anima.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
        anima.SetBool("TKSL", TKSL);
        if (anima.speed >= 5)
        {
            anima.speed = 5;
        }

        if (Input.GetKey(KeyCode.W) && TKSL)
        {
            salto = true;
        }
        
      


        //movimiento horizontal 
        float hinput = Input.GetAxis("Horizontal");
        if (!movement)
        {
            hinput = 0;

        }

        rb2d.AddForce(Vector2.right * speed * hinput);


        if (hinput > 0.1f)
        {
            transform.localScale = new Vector3(6f, 7f, 1f);
        }

        if (hinput < -0.1f)
        {
            transform.localScale = new Vector3(-6f, 7f, 1f);
        }

        // Declaraciones que hacen que el personaje se mueva o se quede quiero 
        // Al presionar una tecla el personaje se mueve y al no presionarla los constrains hacen que se congele el movimiento
        if (Input.GetKey(KeyCode.A))
        {
            despl = true;
        }
        else
        {
            despl = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            despl2 = true;
        }
        else
        {
            despl2 = false;
        }
        //ara que no se congele en el aire ponemos una declaracion con la variable TSKL

        if(TKSL == false)
        {
            if(despl2 == false)
            {
                if (despl == true)
                {
                    rb2d.constraints = RigidbodyConstraints2D.None;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                else
                {
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                    rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
          if(despl == false)
            {
                if (despl2 == true)
                {
                    rb2d.constraints = RigidbodyConstraints2D.None;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                else
                {
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                    rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }

        }
        else
        {
           //para la tecla A
            if (despl == false)
            {
                if (despl2 == true)
                {
                    rb2d.constraints = RigidbodyConstraints2D.None;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                else
                {
                    rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
                    rb2d.constraints = RigidbodyConstraints2D.None;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
        
            }
            if (despl == true)
            {

                rb2d.constraints = RigidbodyConstraints2D.None;
                rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;

            }
            // para la tecla D
            if (despl2 == false)
            {
                if (despl == true)
                {
                    rb2d.constraints = RigidbodyConstraints2D.None;
                    rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                else
                {
                  rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
                  rb2d.constraints = RigidbodyConstraints2D.None;
                  rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
                }

            }


        }
       
        if (despl2 == true)
        {

            rb2d.constraints = RigidbodyConstraints2D.None;
            rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
  
  


    void FixedUpdate()
    {

        if (salto)
        {
            rb2d.AddForce(Vector2.up * FDsalto, ForceMode2D.Impulse);
            salto = false;
        }
        Debug.Log(rb2d.velocity.x);
    }

    void OnBecameInvisible()
    {
        transform.position = new Vector3(-1, 0, 0);
    }

    public void Enemyxs()
    {
        salto = true;
    }

}