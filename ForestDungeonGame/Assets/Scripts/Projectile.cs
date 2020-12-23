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

    void Start()
    {
        StartCoroutine(SelfDestruct(deathTimer));
    }

    public int GetDamage()
    {
        return damage;
    }

    IEnumerator SelfDestruct(float dt)
    {
        yield return new WaitForSeconds(dt);
        Destroy(gameObject);
    }
}
