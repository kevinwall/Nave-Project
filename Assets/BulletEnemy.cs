using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour, IPooledObject
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;

    // Start is called before the first frame update
    public void OnObjectSpawn()
    {
        //Debug.LogWarning("Disparando");
        //Vector3 force = new Vector3((speed * -1f), 0, 0); 
        rb.velocity = transform.up * (speed * -1f);
        //force;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        PlayerStatus player = hitInfo.GetComponent<PlayerStatus>();
        
        if(player != null)
        {
            //Debug.LogWarning("Acertei algo");
            player.TakeDamage(damage);
        }
        
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
