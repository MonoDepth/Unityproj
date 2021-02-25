using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasHandler : MonoBehaviour
{
    public void ToggleItemInfoBox(bool test)
    {
        

        if (test == true) //Disables cavas on leave
        {
            gameObject.SetActive(true);
        }

        if (test == false) //Disables cavas on leave
        {
            gameObject.SetActive(false);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vi startade");
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
