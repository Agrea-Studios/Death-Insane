using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;

public class BDKleys : MonoBehaviour
{
    public class kleys //kleys
    {
        public float kleysV;  //50f; //vida
        public float kleysA;  //5f;  //ataque
        public float kleysD;  //5f;  //defensa
        public float kleysVM;
    }


    kleys kleys1 = new kleys();

    //objetos (armas pociones etc) con los que interactuara kleys
    
    //Armas
    Batemagico BateM = new Batemagico();
    Espadaenllamas Espadaenllamas1 = new Espadaenllamas();

    //Pociones
    PVivaLavida PRegeneracion = new PVivaLavida();


    //objetos



    //Armadura etc
    UniformeZicagrea UniformeMagico = new UniformeZicagrea();




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


    }
    //alteraciones de estado por armas
    public void AltEstadoBateM()
    {
        kleys1.kleysD = kleys1.kleysD + BateM.bateD;
        kleys1.kleysVM = kleys1.kleysVM + BateM.aumentoV;
        kleys1.kleysA = kleys1.kleysA + BateM.bateA;
    }
    public void AltEstadoEspadaLLamas()
    {
        kleys1.kleysA = kleys1.kleysA + Espadaenllamas1.EspadaLLamasA;
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


    //alteracion de estado por objetos


    //alteracion de estados por armaduras
    public void Uniformezicagrea()
    {
        kleys1.kleysA = kleys1.kleysA + UniformeMagico.UniformemagicA;
        kleys1.kleysD = kleys1.kleysD + UniformeMagico.UniformemagicD;
    }
    

    // Update is called once per frame
    void Update()
    {
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

       //al tomar pocion de regeneracion
       if(PRegeneracion.tomar == true)
        {
            TPocionDeRegeneracion();
        }
    }
}
