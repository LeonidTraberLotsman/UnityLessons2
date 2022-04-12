using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 D=new Vector3(2,6,4);
        Vector3 C=new Vector3(4,7,9);
        StartCoroutine(Move(D,C,120));
    }
IEnumerator  Move(Vector3  A,Vector3 B,int frames)
{ 
    Vector3 P=B-A;
    Vector3 Speed =P/frames;
    for(int i=0;i<frames;i++)
    {
        transform.position=A+i*Speed;
        yield return null;
        
    }
    yield return null;
    transform.position=B;
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
