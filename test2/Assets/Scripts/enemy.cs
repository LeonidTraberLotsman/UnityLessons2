using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public Transform Target;
    NavMeshAgent agent;
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        
    }

    
    void Update()
    {
        agent.destination=Target.position;
    }
}
