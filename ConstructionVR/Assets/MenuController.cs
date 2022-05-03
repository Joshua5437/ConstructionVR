using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MenuController : MonoBehaviour
{ 

    public SteamVR_Action_Boolean MenuToggle; 
    public SteamVR_Input_Sources handType; 
    public GameObject Menu; 
    private bool On;

    // Start is called before the first frame update
    void Start()
    {
        MenuToggle.AddOnStateDownListener(ButtonDown, handType); 
        On = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void ButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)  {
        Debug.Log("Menu Button Pressed");  
        if (On == true) {
            Menu.SetActive(false);
            On = false;
        } 
        else { 
            Menu.SetActive(true); 
            On = true;

        }
    }
}
