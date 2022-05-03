using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class VRPlayerScalar : MonoBehaviour
{
    public bool isScaled; 
    public Vector3 Scale;
    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        isScaled = false; 
        Scale = new Vector3(0.4f, 0.4f, 0.4f);
        Player = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isScaled) { 

            Player.localScale = Scale; 
            isScaled = true;
        }
    }
}
