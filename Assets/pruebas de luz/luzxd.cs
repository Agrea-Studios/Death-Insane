using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzxd : MonoBehaviour
{
    public float timer = 0.5f;
    public float timer2 = 1f;
   
    public GameObject Object1;
    private GameObject Object2;
    // Start is called before the first frame update
    void Start()
    {
           StartCoroutine("luz");
           StartCoroutine("luzD");
    }

    // Update is called once per frame
    void Update()
    {
        
      
         Object2 = GameObject.Find("luzxd(Clone)");
           
       
    }
     private IEnumerator luzD()
    {

        yield return new WaitForSeconds(timer);
        
       Destroy(Object2);
       StartCoroutine("luzD");
           


        

    }
  
    private IEnumerator luz()
    {
        yield return new WaitForSeconds(timer2);
        
        for(int I = 0; I < 1; I++)
        {
            Instantiate(Object1);
            

        }
           StartCoroutine("luz");



        

    }



}
