using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerLogic : MonoBehaviour
{
    public GameObject canvasT;
    public canvasHandler canvasHandler;
    private void OnTriggerEnter(Collider other)
    {
        canvasHandler.ToggleItemInfoBox
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        
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
