using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int maxHealth = 200;
    public int currHealth;
    public int points;

    public HealthDisplay healthDisplay;
    public HealthBar healthBar;
    public PointsDisplay pointsDisplay;

    public void setPoints(int points)
    {
        this.points = this.points + points;
        pointsDisplay.setPoints(this.points);
    }

    public void TakeDamage(int damage)
    {
        currHealth -= damage;

        healthBar.SetHealth(currHealth);
        healthDisplay.setHealth(currHealth);

        if(currHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
        currHealth = maxHealth;
        healthDisplay.setHealth(currHealth);

        points = 0;
        pointsDisplay.setPoints(points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
