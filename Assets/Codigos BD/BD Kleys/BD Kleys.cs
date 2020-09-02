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
    public ClasesA.Espadabastardamillamentos espadabastarda1kxd;
    public ClasesA.Batemagico batemagico;
    public ClasesA.Cimitarraelectrica cimitarraelectrik;
    public ClasesA.EspadaBastarda espadabast;
    public ClasesA.Espadaenllamas espadaonfire;
    public ClasesA.Guantedelosmillamentos guantede1k;
    public ClasesA.Lanzadepenas lanzapenaxd;
  
    // ARMADURAS
    public ClasesArmaduras.UniformePortero uniformeporteroxd;
    public ClasesArmaduras.UniformeZicagrea uniformzicagreaxd;

    // OBJETOS 
    public ClasesObjetos.Pmamadoc pmamadocxd;
    public ClasesObjetos.PVivaLavida vivalavidapotion;
   
        
        void Start()
    {
      Clasesxd = GameObject.Find("clasesxd");
        //ARMAS
            espadabenditaxd = Clasesxd.GetComponentInParent<ClasesA.Espadabendita>();
            espadabastarda1kxd = Clasesxd.GetComponentInParent<ClasesA.Espadabastardamillamentos>();
            batemagico = Clasesxd.GetComponentInParent<ClasesA.Batemagico>(); 
            cimitarraelectrik = Clasesxd.GetComponentInParent<ClasesA.Cimitarraelectrica>();
            espadabast = Clasesxd.GetComponentInParent<ClasesA.EspadaBastarda>();
            espadaonfire = Clasesxd.GetComponentInParent<ClasesA.Espadaenllamas>();
            guantede1k = Clasesxd.GetComponentInParent<ClasesA.Guantedelosmillamentos>();       
            lanzapenaxd = Clasesxd.GetComponentInParent<ClasesA.Lanzadepenas>();
        // ARMADURAS
            uniformeporteroxd = Clasesxd.GetComponentInParent<ClasesArmaduras.UniformePortero>(); 
            uniformzicagreaxd = Clasesxd.GetComponentInParent<ClasesArmaduras.UniformeZicagrea>(); 
        //OBJETOS
            pmamadocxd = Clasesxd.GetComponentInParent<ClasesObjetos.Pmamadoc>();
            vivalavidapotion =Clasesxd.GetComponentInParent<ClasesObjetos.PVivaLavida>();


    }


}
