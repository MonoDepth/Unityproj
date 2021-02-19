using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasHandler : MonoBehaviour
{
    GameObject canvasUIElement = GameObject.FindWithTag("findMePleaseCanvas");
    public void ToggleItemInfoBox(bool test)
    {
        if (Input.GetKeyDown("f") && test == true) //Enables on enterance
        {
            canvasUIElement.SetActive(true);
        }

        if(test == false) //Disables cavas on leave
        {
            canvasUIElement.SetActive(false);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        canvasUIElement.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
