using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class construir2 : MonoBehaviour
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
        //para aparecer bate magico en el inventario
      
            for (int i = 0; i < 1; i++)
            {
                Instantiate(construir);
            }
        

    }


    public void desturir(Object destruirSoloEngine)
    {
        Destroy(destruirSoloEngine);
    }
}
