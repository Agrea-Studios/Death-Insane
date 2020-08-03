using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class ControladorBoton : MonoBehaviour
{
   
    
    //script unico para destruir cosas de tipo (Object)
    public void CambiarEscena(string nombre)
    {
        print("cambiando de escena" + nombre);
        SceneManager.LoadScene(nombre);
        
    }

    public void Salir()
    {
        print("SALIENDO DEL JUEGO");
        Application.Quit();
    }

    public void construir(GameObject construir)
    {
        Batemagico bateM = new Batemagico();
        if(bateM.Ibag == true)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(construir);
            }
        }
      
        

    }


    public void desturir(Object destruirSoloEngine )
    {
        Destroy(destruirSoloEngine);
    }
}
