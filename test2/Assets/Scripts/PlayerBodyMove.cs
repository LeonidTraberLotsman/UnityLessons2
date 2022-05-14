using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Random;

public class PlayerBodyMove : MonoBehaviour
{
    public Text hpFloat;


    // Start is called before the first frame update
    public float speed=1;
    public float hp=100;
    public GameObject GO;

    void zdixanie()
    {
        hp=0;
        speed=0;
        GO.SetActive(true);
    }

    void Start()
    {
        
    }
    public void Damage(float uronmoba)
    {
        float q=Random.Range(0,21);
        if(q<=1)
        {
            hp-=uronmoba*3.5f;
            Debug.Log("krit!");
            if(hp<=0)
            {
                zdixanie();
            }
        }
        else
        {
            
            hp-=uronmoba;
            if(hp<=0)
            {
                zdixanie();
            }
            
        }
        hpFloat.text=hp.ToString();
        
        //nu ti krch uron poluchesh, sdelay tam cto nibud

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.forward*speed;
        }
        if((Input.GetKey(KeyCode.S)))
        {
            transform.position = transform.position - transform.forward*speed;
        }
        if((Input.GetKey(KeyCode.D) ))
        {
            transform.position = transform.position + transform.right*speed;
        }
        if((Input.GetKey(KeyCode.A)))
        {
            transform.position = transform.position - transform.right*speed;
        }
    
        
            
        
    }
}
