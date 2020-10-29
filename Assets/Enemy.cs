using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public HealthBar healthBar;

    //public PlayerStatus player;

    //public void setPlayer(PlayerStatus player)
    //{
    //    this.player = player;
    //}

    public void TakeDamage(int damage)
    {
        health -= damage;

        healthBar.SetHealth(health);

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        
        FindObjectOfType<PlayerStatus>().setPoints(20);
        
        FindObjectOfType<AudioManeger>().play("DeathSound");

        //player.setPoints(20);

    }

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
