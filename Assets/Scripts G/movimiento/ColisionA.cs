using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionA : MonoBehaviour
{

    private controladormove colisionUwU;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D colita)

    {
        float DPE = 0.56f;
        if (colita.gameObject.tag == "Enemigo")
        {

            if (transform.position.x + DPE > colita.transform.position.x)
            {
                 if(colisionUwU.atak2 == true)
                 {
                     
                 }
               

            }
        }

    }
    // Update is called once per frame
    void Update()
    { 
      


    }
}
