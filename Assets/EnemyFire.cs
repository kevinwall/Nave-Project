using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;
    public Transform FirePoint;
    public float timeShot;
    private bool shot;
    ObjectPooler objectPooler;
    
    void Start()
    {
        shot = false;
        objectPooler = ObjectPooler.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (!shot)
            StartCoroutine(TimedShooting(timeShot));


        //InvokeRepeating("Spawn", timeSpawn, timeSpawn);
    }

    IEnumerator TimedShooting(float t)
    {
        shot = true;
        yield return new WaitForSeconds(t);
        Shoot();
        shot= false;
    }

    public void Shoot()
    {
        //GameObject ob = GameObject.Instantiate(enemy) as GameObject;
        //Instantiate(bullet, FirePoint.position, FirePoint.rotation);
        objectPooler.SpawnFromPool("Bala", FirePoint.position, FirePoint.rotation);
        //Vector2 newPos = new Vector2(Random.Range(minX, maxX), this.transform.position.y);
        //ob.transform.position = newPos;
    }

    
}
