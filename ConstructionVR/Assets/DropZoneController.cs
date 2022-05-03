using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DropZoneController : MonoBehaviour
{

    public GameObject rHand;
    public GameObject lHand; 
    public Transform snapTransform;
    public bool Box; 
    public GameObject ProgramManager;

    private GameObject ObjectToSnapR; 
    private GameObject ObjectToSnapL; 
    private Hand rScript; 
    private Hand lScript; 

    // Start is called before the first frame update
    void Start()
    {
        rScript = rHand.GetComponent<Hand>(); 
        lScript = lHand.GetComponent<Hand>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other) { 
        if (Box == true) {
            if (other.gameObject.tag == "BoxInteractable") {
                ObjectToSnapR = rScript.currentAttachedObject;
                ObjectToSnapL = lScript.currentAttachedObject;

                if (ObjectToSnapR != null) { 
                    rScript.DetachObject(rScript.currentAttachedObject);
                    ObjectToSnapR.GetComponent<Transform>().localPosition = snapTransform.localPosition;
                    ObjectToSnapR.GetComponent<Transform>().localRotation = snapTransform.localRotation;
                    ProgramManager.GetComponent<ProgramManager>().task1Progress += 1;

                    Destroy(ObjectToSnapR.GetComponent<Throwable>());
                    Destroy(ObjectToSnapR.GetComponent<Interactable>());
                    Destroy(ObjectToSnapR.GetComponent<Rigidbody>());
                    this.gameObject.SetActive(false);


                } 
                else {
                    lScript.DetachObject(lScript.currentAttachedObject);
                
                    ObjectToSnapL.GetComponent<Transform>().localPosition = snapTransform.localPosition; 
                    ObjectToSnapL.GetComponent<Transform>().localRotation = snapTransform.localRotation;
                    ProgramManager.GetComponent<ProgramManager>().task1Progress += 1;

                 
                
                    Destroy(ObjectToSnapL.GetComponent<Throwable>()); 
                    Destroy(ObjectToSnapL.GetComponent<Interactable>());
                    Destroy(ObjectToSnapL.GetComponent<Rigidbody>());
                    this.gameObject.SetActive(false);
                }


            } 
        }  
        else { 
            if (other.gameObject.tag == "BagInteractable") {
                ObjectToSnapR = rScript.currentAttachedObject;
                ObjectToSnapL = lScript.currentAttachedObject;

                if (ObjectToSnapR != null) { 
                    rScript.DetachObject(rScript.currentAttachedObject);
                    ObjectToSnapR.GetComponent<Transform>().localPosition = snapTransform.localPosition;
                    ObjectToSnapR.GetComponent<Transform>().localRotation = snapTransform.localRotation;
                    ProgramManager.GetComponent<ProgramManager>().task2Progress += 1;

                    Destroy(ObjectToSnapR.GetComponent<Throwable>());
                    Destroy(ObjectToSnapR.GetComponent<Interactable>());
                    Destroy(ObjectToSnapR.GetComponent<Rigidbody>());
                    this.gameObject.SetActive(false);


                } 
                else {
                    lScript.DetachObject(lScript.currentAttachedObject);
                
                    ObjectToSnapL.GetComponent<Transform>().localPosition = snapTransform.localPosition; 
                    ObjectToSnapL.GetComponent<Transform>().localRotation = snapTransform.localRotation;
                    ProgramManager.GetComponent<ProgramManager>().task2Progress += 1;

                 
                
                    Destroy(ObjectToSnapL.GetComponent<Throwable>()); 
                    Destroy(ObjectToSnapL.GetComponent<Interactable>());
                    Destroy(ObjectToSnapL.GetComponent<Rigidbody>());
                    this.gameObject.SetActive(false);
                }


            } 
        }
    }
}
