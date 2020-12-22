using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    public float speed, deathTimer;


    private Projectile()
    {
    }

    public Projectile(int d, float s, float dt)
    {
        damage = d;
        speed = s;
        deathTimer = dt;
    }

    public int GetDamage()
    {
        return damage;
    }

    void Start()
    {
        StartCoroutine(SelfDestruct(deathTimer));
    }
    
    IEnumerator SelfDestruct(float dt)
    {
        yield return new WaitForSeconds(dt);
        Destroy(gameObject);
    }
}
