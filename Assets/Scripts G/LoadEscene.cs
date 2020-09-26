using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadEscene : MonoBehaviour
{
    public string escena;
    public GameObject puerta;
    private void OnTriggerStay2D(Collider2D obj)
    {
        if(obj.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(escena);
            }
        }
    }
}
