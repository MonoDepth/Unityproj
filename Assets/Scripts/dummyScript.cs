using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyScript : MonoBehaviour
{
    public void dummyToggle(bool dummyTest)
    {
        if (dummyTest == true)
        {
            gameObject.SetActive(true);
        }
        
        if(dummyTest == false)
        {
            gameObject.SetActive(false);
        }
            
    }


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
