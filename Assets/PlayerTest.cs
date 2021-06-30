using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        // startPosition = new Vector3(0,0,0);
        // transform.rotation
        // transform.localScale
        // grab the current pos and assign new position value
        transform.position = startPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
