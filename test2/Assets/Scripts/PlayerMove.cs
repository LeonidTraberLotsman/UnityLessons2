using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    float xRotation=0;
    public float MS=0;
    public Transform body;
    public PlayerBodyMove player;
    public int MaxAmmo;
    public int CurAmmo;
    public int BagAmmo;
    public Text AmmoCaunter;
    void UpdAmmoCunter()
    {
        AmmoCaunter.text=CurAmmo+"/"+BagAmmo;
    }
    void Reload()
    {
        int Pos=MaxAmmo-CurAmmo;
        if(BagAmmo>Pos)
        {
            BagAmmo-=Pos;
            CurAmmo+=Pos;
        }
        else
        {
            CurAmmo+=BagAmmo;
            BagAmmo=0;
        }
        UpdAmmoCunter();
    }
    void Start()
    {
        UpdAmmoCunter();
    }
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*Time.deltaTime*MS;
        float mouseY=Input.GetAxis("Mouse Y")*Time.deltaTime*MS;
        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation,-90,90);
        transform.localRotation=Quaternion.Euler(xRotation,0,0);
        body.Rotate(Vector3.up*mouseX);
        if(Input.GetKeyDown(KeyCode.Mouse0) && (CurAmmo>0))
        {
            Debug.Log("pow");
            RaycastHit hit;
            if(Physics.Raycast(transform.position,transform.forward,out hit))
            {
                Debug.Log(hit.transform.name);
                if(hit.transform.GetComponent<enemy>())
                {
                    Debug.Log("-1");
                    
                    if(player.hp>0)
                    {
                        hit.transform.GetComponent<enemy>().Die();

                    }
                }
            }
            CurAmmo=CurAmmo-1;
            UpdAmmoCunter();
        }
        if(Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("gvgvgv");
            Reload();
        }
    }
}
