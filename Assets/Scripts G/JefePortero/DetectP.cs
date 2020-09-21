using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectP : MonoBehaviour
{
    private JPmov player;

    private void Start()
    {
        player = GetComponentInParent<JPmov>();
    }
    private void OnTriggerEnter2D(Collider2D tocao)
    {
        if(tocao.tag =="Player")
        {
            player.despierta = true;
        }
    }

 }    


