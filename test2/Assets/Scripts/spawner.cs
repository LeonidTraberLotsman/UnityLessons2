using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ZombiePrefab;
    public Transform Target;

    IEnumerator SpawnRow(){
        while(true){
            yield return new WaitForSeconds(1);
            Spawn();
        }
    }
    void Spawn()
    {
        GameObject Zombie=Instantiate(ZombiePrefab);
        Zombie.transform.position=transform.position;
        enemy en =Zombie.GetComponent<enemy>();
        en.Target=Target;

    }
    void Start()
    {
        StartCoroutine(SpawnRow());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
