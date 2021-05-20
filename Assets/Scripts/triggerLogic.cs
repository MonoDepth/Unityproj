using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerLogic : MonoBehaviour
{
    bool test;
    public canvasHandler canvasHandler;
    public Transform cameraObject;
    public float triggerDistance = 10;
    public Transform playerHead;
    
     public void OnTriggerEnter(Collider col)
     {
        Text textB = (Text)FindObjectOfType<Text>(true);
        if (!col.CompareTag("ignoreInteract"))
        {

            Debug.Log(col.name);
            test = true;
            Text tB = textB.GetComponent<Text>();
            string testName = string.Copy(col.name);
            Debug.Log($"testName: {testName}");
            tB.text = $"This object is called {testName}";
            Debug.Log("Stopping point");
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
