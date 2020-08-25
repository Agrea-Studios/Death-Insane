using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;

public class BDKleys : MonoBehaviour
{
     public GameObject Clasesxd; 
    //ARMAS Rodrigo
    public ClasesA.Espadabendita espadabenditaxd;
    public ClasesA.Espadabastardamillamentos xd;
  

    void Start()
    {
      Clasesxd = GameObject.Find("clasesxd");
      espadabenditaxd = Clasesxd.GetComponentInParent<ClasesA.Espadabendita>();
    }


    






    

    
     
   





 
}
