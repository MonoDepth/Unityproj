using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLogic : MonoBehaviour
{
    bool test;
    public canvasHandler canvasHandler;
    public Transform cameraObject;
    public float triggerDistance = 10;
    public Transform playerHead;
     public void OnTriggerEnter(Collider col)
     {
        if (!col.CompareTag("ignoreInteract"))
        {
            Debug.Log(col.name);
            test = true;
        }
     }

     public void OnTriggerExit(Collider col)
     {
        if (!col.CompareTag("ignoreInteract"))
        {
            test = false;
            canvasHandler.ToggleItemInfoBox(test);
        }
     }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.DrawRay(playerHead.position, cameraObject.forward * triggerDistance);
        bool oldTest = test;
        test = Physics.Raycast(playerHead.position, cameraObject.forward, triggerDistance);*/

        if (Input.GetKeyDown("f") && test == true) // Enables if f is pressed while in a trigger
        {
            canvasHandler.ToggleItemInfoBox(test);
        }

        /*else if(test == false && oldTest == true)
        {
            canvasHandler.ToggleItemInfoBox(test);
        }*/

    }
}
