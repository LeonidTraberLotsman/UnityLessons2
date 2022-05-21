using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public float zloykvadratikuron=2;
    public Transform Target;
    
    NavMeshAgent agent;
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        
        
    }

    public void Die()
    {
        
        
            Destroy(this.gameObject);
        
        
    }
    void Update()
    {
    
       agent.destination=Target.position;
    if(Vector3.Distance(transform.position,Target.position)<2)
    {
        Debug.Log("ты умер");
        if(Target.GetComponent<PlayerBodyMove>())
        {
            Target.GetComponent<PlayerBodyMove>().Damage(zloykvadratikuron);
        }
    }
    }
}


