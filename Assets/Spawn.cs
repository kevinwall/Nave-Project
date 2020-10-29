using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //public Transform SpawnPoint;
   // public GameObject EnemyPrefab;

    //void Start()
    //{
     //   Instantiate(EnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);        
   // }

    public GameObject enemy;
    public float minX = 0f;
    public float maxX = 7f;

    public float timeSpawn;
    private bool spawned;
    private float sec;
    void Start()
    {
        spawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawned)
            StartCoroutine(TimedSpawn(timeSpawn));


        //InvokeRepeating("Spawn", timeSpawn, timeSpawn);
    }

    public void Spawner()
    {
        GameObject ob = GameObject.Instantiate(enemy) as GameObject;
        Vector2 newPos = new Vector2(Random.Range(minX, maxX), this.transform.position.y);
        ob.transform.position = newPos;
    }

    IEnumerator TimedSpawn(float t)
    {
        spawned = true;
        yield return new WaitForSeconds(t);
        Spawner();
        spawned = false;
    }

}
