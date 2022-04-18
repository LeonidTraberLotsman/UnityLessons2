using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.forward*speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position - transform.forward*speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + transform.right*speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - transform.right*speed;
        }
    }
}
