using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _horizontalInput;
    [SerializeField]
    private float _verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //new vector3 (1,0,0)* realtime * 5
        //transform.Translate(Vector3.left *  _speed * Time.deltaTime);
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
        transform.Translate(new Vector3(-_horizontalInput, 0, -_verticalInput ) * _speed * Time.deltaTime);
        //transform.Translate(new Vector3(0, _verticalInput, 0) * _speed * Time.deltaTime);
    }
}
