using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    //public PlayerStatus player;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * (speed * 1f);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        //if(player == null)
        //{
            //Debug.LogWarning("Achei o player");
        //    player = hitInfo.GetComponent<PlayerStatus>();

        //}

        if(enemy != null)
        {
            enemy.TakeDamage(damage);
            //enemy.setPlayer(player);
            Destroy(gameObject);
        }
    }

}
