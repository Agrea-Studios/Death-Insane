using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;

public class BDKleys : MonoBehaviour
{
    public class kleys //kleys
    {
        public float kleysV;  //50f; //vida
        public float kleysA;  //5f;  //ataque
        public float ATKMK;   //ataque maximo
        public float kleysD;  //5f;  //defensa
        public float kleysVM; //vida maxima
        public float kleysVELM; //velocidad maxima
    }

    // kleys1.kleysV = 50;
    kleys kleys1 = new kleys();

    //objetos (armas pociones etc) con los que interactuara kleys

    //Armas
    Batemagico BateM = new Batemagico();
    Espadaenllamas Espadaenllamas1 = new Espadaenllamas();
    EspadaBastarda EBastarda = new EspadaBastarda();
    Espadabastardamillamentos EBMIL = new Espadabastardamillamentos();
    Lanzadepenas lanzaP = new Lanzadepenas();
    Cimitarraelectrica cimi = new Cimitarraelectrica();

    //Pociones
    PVivaLavida PRegeneracion = new PVivaLavida();
    Pmamadoc PocionF = new Pmamadoc();
    

    //objetos



    //Armadura etc
    UniformeZicagrea UniformeMagico = new UniformeZicagrea();
    UniformePortero uniformeP = new UniformePortero();
   

    //enemigos con los que kleys interacturara
    Jefeportero jefep = new Jefeportero();



    //personajes con los que kleys va a interactuar




    // Start is called before the first frame update
    void Start()
    {
        //variables de kleys 
        
        kleys1.kleysA = 5f;
        kleys1.kleysD = 5f;
        kleys1.kleysV = 50f;
        kleys1.kleysVM = 50;
        kleys1.ATKMK = 15;
   
    }



    //alteraciones de estado por armas

    public void AltEstadoBateM() // bate magico
    {
        kleys1.kleysD = kleys1.kleysD + BateM.bateD;
        kleys1.kleysVM = kleys1.kleysVM + BateM.aumentoV;
        kleys1.kleysV = kleys1.kleysV + BateM.aumentoV;
        kleys1.kleysA = kleys1.kleysA + BateM.bateA;
        kleys1.ATKMK = kleys1.ATKMK + BateM.bateA;
    }
    public void AltEstadoLanzap()
    {
        kleys1.kleysA = kleys1.kleysA + lanzaP.ATK;
        kleys1.ATKMK = kleys1.ATKMK + lanzaP.ATK;
    }
    public void AltEstadoCimi()
    {
        kleys1.kleysA = kleys1.kleysA + cimi.ATK;
        kleys1.ATKMK = kleys1.ATKMK + cimi.ATK;
    }
    public void AltEstadoEspadaLLamas() // espada en llamas
    {
        kleys1.kleysA = kleys1.kleysA + Espadaenllamas1.EspadaLLamasA;
        kleys1.ATKMK = kleys1.ATKMK + Espadaenllamas1.EspadaLLamasA;
    }
    public void AltEstadoEsBastard() // espada bastarda
    {
        kleys1.kleysA = kleys1.kleysA + EBastarda.ataque;
        kleys1.ATKMK = kleys1.ATKMK + EBastarda.ataque;
    }
    public void AltEstadoEBMIL() // espada bastarda mil lamentos
    {
        kleys1.kleysA = kleys1.kleysA + EBMIL.ATK;
        kleys1.ATKMK = kleys1.ATKMK + EBMIL.ATK;
        kleys1.kleysVM = kleys1.kleysVM + EBMIL.AVM;
        kleys1.kleysV = kleys1.kleysV + EBMIL.AVM;
    }

    //alteraciones de estado por pociones
    public void TPocionDeRegeneracion()
    {
        if(kleys1.kleysV <= kleys1.kleysVM)
        {
            kleys1.kleysV = kleys1.kleysV + PRegeneracion.aumento;

            if(kleys1.kleysV > kleys1.kleysVM)
            {
                kleys1.kleysV = kleys1.kleysVM;
            }

        }
    }
    public void TPocionF()
    {
        if(kleys1.kleysA <= kleys1.ATKMK)
        {
            kleys1.kleysA = kleys1.kleysA + PocionF.ATKM;

            if(kleys1.kleysA > kleys1.ATKMK)
            {
                kleys1.kleysA = kleys1.ATKMK;
            }


        }
    }


    //alteracion de estado por objetos


    //alteracion de estados por armaduras
    public void Uniformezicagrea()
    {
        kleys1.kleysA = kleys1.kleysA + UniformeMagico.UniformemagicA;
        kleys1.ATKMK = kleys1.ATKMK + UniformeMagico.UniformemagicA;
        kleys1.kleysD = kleys1.kleysD + UniformeMagico.UniformemagicD;
    }

    

    // Update is called once per frame
    void Update()
    {

        //AL EQUIPAR ARMAS

        //al equipar bate M
       if(BateM.equipado == true)
        {
            AltEstadoBateM();
        }
       //al equipar espada en llamas 
       if(Espadaenllamas1.equipado == true)
        {
            AltEstadoEspadaLLamas();
        }
       //al equipar espada bastarda
       if(EBastarda.equipado == true)
        {
            AltEstadoEsBastard();
        }
       //al equipar espada bastarda de los mil lamentos 
       if(EBastarda.equipado == true)
        {
            AltEstadoEBMIL();
        }


       //AL EQUIPAR POCIONES

       //al tomar pocion de regeneracion
       if(PRegeneracion.tomar == true)
        {
            TPocionDeRegeneracion();
        }
    }
}
