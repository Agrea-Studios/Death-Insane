using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeDemonioPortero : MonoBehaviour
{
        //JefeDP = JefeDemonioPortero
    public BDKleys KleysBD;
    public GameObject Ckleys;
    public float JefeDPV = 170f; //vida
    public float JefeDPA = 40f; // ataque
    public float JefeDPD = 15f; // defensa
    public float JefeDPVe = 7f; // velocidad

    // Start is called before the first frame update
    void Start()
    {
        Ckleys = GameObject.Find("Player");
        KleysBD = Ckleys.GetComponentInParent<BDKleys>();
    }

    public void restajefe(){
        JefeDPV = JefeDPV - KleysBD.kleysa; // jefe ataca a kleys
        JefeDPV = JefeDPV + JefeDPD; 
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}
