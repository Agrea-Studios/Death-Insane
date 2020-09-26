using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPmov : MonoBehaviour
{
    public bool CCH1;
    public float speed = 3f;
    public float MSp = 2.3f;
    public bool despierta;
    public bool moviendose;
    Rigidbody2D rb2d; 
    public Animator anom;
    SpriteRenderer lel;


    
    void Start()
    {
        anom = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        lel = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D cambio)
    {
        if (cambio.tag == "Limitex")
        {
            CCH1 = true;
        }
        
    }

    void Update()
    {
        anom.SetBool("aquitoy", despierta);
    }

    private void FixedUpdate()
    {
        if (despierta == true)
        {
            rb2d.AddForce(Vector2.left * speed);
            float LS = Mathf.Clamp(rb2d.velocity.x, -MSp, MSp);
            rb2d.velocity = new Vector2(LS, rb2d.velocity.y);
        }

        if (CCH1 == true)
        {
            speed = -speed;
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            CCH1 = false;
        }

        
    }
    
     
}
