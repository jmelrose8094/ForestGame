using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health, damage;
    public float moveSpeed;

    public Enemy()
    {
    }

    public Enemy(int h, int d, float s)
    {
        health = h;
        damage = d;
        moveSpeed = s;
    }

    public int GetHealth()
    {
        return health;
    }
    public int GetDamage()
    {
        return damage;
    }

    public void SubtractFromHealth(int dmg)
    {
        health = health - dmg;

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
