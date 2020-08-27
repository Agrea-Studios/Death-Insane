using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TKSL : MonoBehaviour


{
    private controladormove Player;
    
    // Start is called before the first frame update

    void Start()
    {
        Player = GetComponentInParent<controladormove>();

    }

    void OnCollisionEnter2D(Collision2D ColP)
    {
        if (ColP.gameObject.tag == "piso")
        {
            Player.TKSL = true;
        }
    }
    void OnCollisionExit2D(Collision2D ColP)
    {
        if (ColP.gameObject.tag == "piso")
        {
            Player.TKSL = false;
        }
    }
}