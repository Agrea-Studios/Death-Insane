using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;

public class FixCanvasAP : MonoBehaviour
{
    private Canvas ap;

    private Camera Tc;
    
    enum RenderModeStates {camera, overlay, world}
    RenderModeStates apR;
    
    // Start is called before the first frame update
    void Start()
    {
        ap = GetComponent<Canvas>();
        Tc = Camera.main;
    }
   
    // Update is called once per frame
    void Update()
    {
        
        ap.renderMode = RenderMode.ScreenSpaceCamera;
        apR = RenderModeStates.camera;
        ap.worldCamera = Tc;
    }
}
