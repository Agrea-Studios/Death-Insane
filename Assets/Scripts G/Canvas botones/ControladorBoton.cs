using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class ControladorBoton : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {

        print("cambiando de escena" + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        print("SALIENDO DEL JUEGO");
        Application.Quit();//tengo hambre

    }

   public void construir(GameObject construir)
    {
        for (int i = 0; i < 1; i++)
        {

            Instantiate(construir);
        }
    }

    public void desturir(GameObject destruir)
    {
        Destroy(destruir);
    }
}
