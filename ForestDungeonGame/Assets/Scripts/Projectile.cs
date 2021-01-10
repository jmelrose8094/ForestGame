using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 0;
    public float speed = 5f, deathTimer = 3f;
    //public GameObject Projectile;


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

    void Update()
    {
        transform.Translate(0, -Time.deltaTime *10f, 0);
    }


    public void Initilize(int d, float s, float dt)
    {
        damage = d;
        speed = s;
        deathTimer = dt;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");

        if (other.gameObject.tag=="Breakable")
        {
            other.gameObject.GetComponent<Enemy>().SubtractFromHealth(damage);
        }
        if(other.gameObject.name != "Player")
        {
            Destroy(this.gameObject);
        }
        
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
