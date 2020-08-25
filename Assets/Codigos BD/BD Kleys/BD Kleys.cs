using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;

public class BDKleys : MonoBehaviour
{
    //ARMAS Rodrigo

    //bate magico
    public Batemagico batem;
    public GameObject batito;

    //Espada en llamas 

    public Espadaenllamas Espadall;
    public GameObject Espadita;

    //Espada Bastarda
    public EspadaBastarda EspadaBas;
    public GameObject EspadaB;

    //Espadabastardamillamentos
    public Espadabastardamilllamentos Esplamentos;
    public GameObject EspadaLame;

    //Lanzadepenas
    public Lanazadepenas Lanzap;
    public GameObject Labzapenas;
    //Cimitarraelectrica
    public Cimitarraelectrica Cimi;
    public GameObject Cimielec;

    // ARMADURAS GABRIEL

    //uniforme zicagrea

    public UniformeZicagrea uniformzic;
    public GameObject unizic;

    // uniforme portero
    public Uniformeportero unipor;
    public GameObject uniport;


    void Start()
    {
        batito = GameObject.Find("bates");
        batem = batito.GetComponent<Batemagico>();
        Espadita = GameObject.Find("");
        Espadall = Espadita.GetComponent<Espadaenllamas>();
        EspadaB = GameObject.Find("");
        EspadaBas = EspadaB.GetComponent<EspadaBastarda>();
        EspadaLame = GameObject.Find("");
        Esplamentos = EspadaLame.GetComponent<Espadabastardamillamentos>();
        Labzapenas = GameObject.Find("");
        Lanzap = Labzapenas.GetComponent<Lanzadepenas>();
        Cimielec = GameObject.Find("");
        Cimi = Cimielec.GetComponent<Cimitarraelectrica>();



        unizic = GameObject.Find("");
        uniformzic = unizic.GetComponent<uniformezicagrea>();
        uniport = GameObject.Find("");
        unipor = uniport.Getcomponent<uniformeportero>();
    }


    






    

    
     
   





    //ALTERACIONES DE ESTADO POR ARMAS

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
    dd



    //alteraciones de estado por armas
    

    // Update is called once per frame
    void Update()
    {

        //AL EQUIPAR ARMAS

        //al equipar bate M
        if (Batem.equipado == true)
        {
            funcionesequuip.AltEstadoBateM(batem.bateA, bateD, aumentoV);
        }
        
        if(Espadall.equipado == true)
        {
            funcionesequuip.
        }
        
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
      


       //AL EQUIPAR POCIONES

       //al tomar pocion de regeneracion
       if(PRegeneracion.tomar == true)
        {
            TPocionDeRegeneracion();
        }
    }
}
