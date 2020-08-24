using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestordeestado 
{
    // Start is called before the first frame update
      
    public static void guardarestado(MonoBehaviour datos){
     PlayerPrefs.SetString("SLOT1", JsonUtility.ToJson(datos));
    }

    public static void cargarestado(MonoBehaviour datos){
    JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("SLOT1"), datos);

    }

}
