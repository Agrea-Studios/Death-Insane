using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opbc : MonoBehaviour
{
    public MonoBehaviour Datos;

   public void guardarpartida(){
    Gestordeestado.guardarestado(Datos);
   } 

   public void cargarestado(){
       Gestordeestado.cargarestado(Datos);
   }



}
