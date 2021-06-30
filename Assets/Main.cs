using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if space key is pressed down
        // print a message
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key pressed");
        }

        //if e key is held down

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holdinf E!");
        }
        //if we lift up f key
        //print lifting up f key
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Lifted F key!");
        }
    }
}
