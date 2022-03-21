using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     transform.position=new Vector3(1,2,3);
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey(KeyCode.Space))
    {
      transform.position=transform.position+new Vector3(0,0.01f,0);  
    }
    }
    
}
