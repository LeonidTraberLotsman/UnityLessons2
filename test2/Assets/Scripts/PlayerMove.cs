using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    float xRotation=0;
    public float MS=0;
    public Transform body;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*Time.deltaTime*MS;
        float mouseY=Input.GetAxis("Mouse Y")*Time.deltaTime*MS;
        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation,-90,90);
        transform.localRotation=Quaternion.Euler(xRotation,0,0);
        body.Rotate(Vector3.up*mouseX);
    }
}
