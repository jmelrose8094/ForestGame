using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 0;
    public float speed = 0f, deathTimer = 20f;


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
        //StartCoroutine(SelfDestruct(deathTimer));
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        print(speed);
    }

    public void Initilize(int d, float s, float dt)
    {
        damage = d;
        speed = s;
        deathTimer = dt;
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


    public void FireProjectille()
    {
        //TODO finish this
    }
}
