using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batemagico : MonoBehaviour 
{
  public class Batemagicouwu : ArmaComun{
    string Nombre;
    float Daño;
    Batemagicouwu(string NombreS, float daño, float aumentoVL, float aumentoV)
    : base(NombreS,daño, aumentoV, aumentoV)
    {
    

    }
  }

}
