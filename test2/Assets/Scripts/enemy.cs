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

    public void Die()
    {
        Destroy(this.gameObject);
    }
    void Update()
    {
        agent.destination=Target.position;
    }
}
