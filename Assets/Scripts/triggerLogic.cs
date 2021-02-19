using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerLogic : MonoBehaviour
{
    bool test;
    public canvasHandler canvasHandler;
    public void OnTriggerEnter()
    {
        test = true;
        canvasHandler.ToggleItemInfoBox(test);
    }

    public void OnTriggerExit()
    {
        test = false;
        canvasHandler.ToggleItemInfoBox(test);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
